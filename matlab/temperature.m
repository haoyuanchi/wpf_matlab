%temperature.m
function T=temperature(B,N,M,A,ALFA1,DX,DY,EDA0,T0,P,H) 
%This function is to calculate the temperature distribution of journal bearing
%求解温度场
EDA=zeros(N,M);
X=zeros(1,N);
Y=zeros(1,M);
T=T0/A.*ones(N,M);
KG=0;
ERT=1;
while (ERT>1e-6&&KG<10)
ERT=0;
for i=2:N
    for j=1:(M/2+1)
        TOLD=T(i,j);
        EDA(i,j)=exp((log(EDA0)+9.67)*(((A*T(i,j)-138)/(T0-138))^(-1.1)-1));%无量纲粘度公式 
        if (i~=N)
            DPDX=0.5*(P(i+1,j)-P(i-1,j))/DX;
        end
        if (i==N)
            DPDX=0.5*(P(1,j)-P(i-1,j))/DX;
        end
        QX=0.5*H(i,j)-0.5*H(i,j)^3*DPDX;
        DPDY=ALFA1*(P(i,j+1)-P(i,j))/DY;
        if (j==M/2+1)
            DPDY=0;
        end
        QY=-0.5*H(i,j)^3*DPDY;
        AA=QX/DX*T(i-1,j)-ALFA1*QY*T(i,j+1)/DY;
        AB=2*EDA(i,j)/H(i,j);
        AC=6*H(i,j)/EDA(i,j)*(DPDX^2+DPDY^2);
        BB=QX/DX-ALFA1*QY/DY;
        T(i,j)=(AA+AB+AC)/BB;
        if (A*T(i,j)>403)
            X(i)=(i-1)*DX*180/3.1415926;
            Y(j)=(-0.5+(j-1)*DY)*B;
            disp([num2str(X(i)),'°',num2str(Y(j)),'温度超过极限值100℃！']);
            return;
        end
        T(i,j)=0.7*TOLD+0.3*T(i,j);
        ERT=ERT+abs(T(i,j)-TOLD)/T0;  %残差
    end
end
ERT=A*ERT/((N-1)*(M-1));
KG=KG+1;
for j=1:M
    T(1,j)=0.5*(T(1,j)+T(N,j));
end
disp(['能量方程残差=',num2str(ERT),',迭代第',num2str(KG),'次']); %能量方程求解残差及迭代次数
end
for i=1:N
    for j=1:M/2
        T(i,M-j+1)=T(i,j);
        EDA(i,M-j+1)=EDA(i,j);
    end
end
%温度场求解完