%pressure.m
function P=pressure(N,M,DX,ALFA,H,EDA)
%This function is to calculate the pressure distribution of journal bearing without taking the deformation into account
%求解压力场
P=zeros(N,M);
for i=2:(N-1)   %初始化内部压力场
    for j=2:(M-1)
        P(i,j)=0.5;
    end
end
for j=1:M   %定义边界压力
    P(1,j)=0;
    P(N,j)=0;
end
for i=1:N
    P(i,1)=0;
    P(i,M)=0;
end
IK=0;
C1=1;
while(C1>1e-6)
C1=0;
ALOAD=0;
for i=2:(N-1)
    i1=i-1;
    i2=i+1;
    for j=2:(M-1)
        PD=P(i,j);
        j1=j-1;
        j2=j+1;
        A1=(0.5*(H(i2,j)+H(i,j)))^3/(0.5*(EDA(i2,j)+EDA(i,j)));
        A2=(0.5*(H(i,j)+H(i1,j)))^3/(0.5*(EDA(i,j)+EDA(i1,j)));
        A3=ALFA*H(i,j)^3/(0.5*(EDA(i,j2)+EDA(i,j)));
        A4=ALFA*H(i,j)^3/(0.5*(EDA(i,j)+EDA(i,j1)));
        A5=A1*P(i2,j)+A2*P(i1,j)+A3*P(i,j2)+A4*P(i,j1);
        A6=A1+A2+A3+A4;
        P(i,j)=(-DX*(H(i2,j)-H(i1,j))+A5)/A6;
        P(i,j)=0.7*PD+0.3*P(i,j); %松弛迭代
        if (P(i,j)<0) %小于0的压强值设为0
            P(i,j)=0;
        end
        C1=C1+abs(P(i,j)-PD);
        ALOAD=ALOAD+P(i,j);
    end
end
IK=IK+1;
C1=C1/ALOAD;
%disp(['雷诺方程残差=',num2str(C1),',迭代第',num2str(IK),'次']);
end
%压强场求解完
