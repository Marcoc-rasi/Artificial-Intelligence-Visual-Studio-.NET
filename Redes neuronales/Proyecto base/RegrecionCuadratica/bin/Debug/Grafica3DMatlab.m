
x = xlsread('miExcel.xlsx','A1:A3601');
y = xlsread('miExcel.xlsx','B1:B3601');
z = xlsread('miExcel.xlsx','C1:C3601');
xAjuste= xlsread('miExcel.xlsx','E1:E56');
yAjuste= xlsread('miExcel.xlsx','F1:F56');
zAjuste= xlsread('miExcel.xlsx','G1:G56');
[XA,YA] = meshgrid(xAjuste,yAjuste);
[X,Y] = meshgrid(x,y);
[Z] = meshgrid(z);
[ZA] = meshgrid(zAjuste);
axis equal
xlabel('m')
ylabel('b')
zlabel('ECM') 
plot3(x,y,z,xAjuste,yAjuste,zAjuste,'O')
%surf(X,Y,Z)