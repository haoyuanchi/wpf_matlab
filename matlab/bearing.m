%求解雷诺方程，计算不同偏心率的载荷，形成偏心率-载荷数据库。
%clear;
%clc;
%D=input('请输入轴径直径(D)(mm)：');
%B=input('请输入轴瓦宽(B)(m)：');
%Rc=input('请输入半径间隙(Rc)(mm)：');
%AN=input('请输入轴承的转速(N)(rpm)：');
%T0=input('请输入润滑介质初始温度(T0)(℃)：');
%EDA0=input('请输入润滑介质在T0的粘度(u0)(Pa.s)：');
%Ro=input('请输入润滑介质的密度(Ro)(kg/m^3)：');
%C=input('请输入润滑介质的比热容(C)(J/(kg.K))：');
%pc=input('请输入轴承测试最大压强(pc)(Pa)：');
%tc=input('请输入轴承测试最大温度(tc)(℃)：');


D = 50;
B = 30;
Rc = 0.05;
AN = 3000;
T0 = 35;
EDA0 = 0.03;
Ro = 860;
C = 1880;
pc = 1000000;
tc = 50;

AJ=4.184; %热功当量
PI=3.1415926;
N=41; %周向节点数
M=31; %轴向节点数
R=D/2;
DX=2*PI/(N-1); %周向单元弧度
DY=1/(M-1);  %轴向单元无量纲长度
ALFA1=R/B; %系数
RATIO=Rc/R; %间隙比
U=R*AN*2*PI/60/1000; %线速度 m/s
ALFA=(R/B*DX/DY)^2;
A=1000*U*R*EDA0/(2*AJ*Ro*C*Rc^2);
T0=T0+273;
EPSON=[0:0.1:0.7,0.75:0.05:0.95]; %定义偏心率值 EPSON=[0.1:0.05:0.65,0.7:0.025:0.95,0.95:0.01:0.99];
lenE=length(EPSON);
Pmax=zeros(1,lenE);
for k=1:lenE
    %流场初始化
    X=zeros(1,N);
    Y=zeros(1,M);
    H=zeros(N,M);
    EDA=ones(N,M);
    for i=1:N
        X(i)=(i-1)*DX;
    end
    for j=1:M
        Y(j)=-0.5+(j-1)*DY;
        for i=1:N
            H(i,j)=1+EPSON(k)*cos(X(i));
        end
    end
    %初始化完毕
    %计算压力场
    P=pressure(N,M,DX,ALFA,H,EDA);
    Pmax(k)=max(max(P)); 
    %保存Pmax
end
%量纲化
Pc=pc/(6*U*EDA0*R/Rc^2*1000);
Tc=(tc+273)/A;
EPSON0=0;
for k=1:lenE-1
    if (Pc>Pmax(k)&&Pc<Pmax(k+1))
        EPSON0=EPSON(k)+(Pc-Pmax(k))*(EPSON(k+1)-EPSON(k))/(Pmax(k+1)-Pmax(k));
    end
end
if EPSON0==0
    k1=Pc/Pmax(lenE);
    P=k1.*P;
    T=temperature(B,N,M,A,ALFA1,DX,DY,EDA0,T0,P,H);
    Tmax=max(max(T));
    k2=Tc/Tmax;
    T=k2.*T;
    disp(['偏心率=',num2str(EPSON(lenE)),',最大压强=',num2str(6*U*EDA0*R/Rc^2*1000*Pmax(lenE)/1000000),'MPa,最大温度=',num2str(A*Tmax-273),'℃']);
else
    %流场初始化
    X=zeros(1,N);
    Y=zeros(1,M);
    H=zeros(N,M);
    EDA=ones(N,M);
    for i=1:N
        X(i)=(i-1)*DX;
    end
    for j=1:M
        Y(j)=-0.5+(j-1)*DY;
        for i=1:N
            H(i,j)=1+EPSON0*cos(X(i));
        end
    end
    %初始化完毕
    %计算压力场
    P=pressure(N,M,DX,ALFA,H,EDA);
    T=temperature(B,N,M,A,ALFA1,DX,DY,EDA0,T0,P,H);
    P0max=max(max(P));
    Tmax=max(max(T));
    %disp(['偏心率=',num2str(EPSON0),',最大压强=',num2str(6*U*EDA0*R/Rc^2*1000*P0max/1000000),'MPa,最大温度=',num2str(A*Tmax-273),'℃']);
end
h=Rc.*H;%mm
p=6*U*EDA0*R/Rc^2*1000.*P;%Pa
t=A.*T-273; %℃
theta=0:360/(N-1):360; %°
z=-B/2:B/(M-1):B/2;  %mm
[Z,THETA]=meshgrid(z,theta);
%subplot(1,2,1)
%mesh(Z,THETA,p)
%subplot(1,2,2)
%mesh(Z,THETA,t)