//int [][] table = new int[8][8];
string x="";
string y="";
string[] table = new string [] {"A", "B", "C", "D", "E", "F", "G", "H"};

//ingresa pos x
Console.Write("Ingrese la posiicon del caballo x {A-H}: ");
x=Console.ReadLine();

//ingresa pos y
Console.Write("Ingrese la posiicon del caballo y {1-8}: ");
y=Console.ReadLine();

//obtione la posicion de la tabla de letras
int coorx=(Array.IndexOf(table, x)+1);
int coory = Convert.ToInt32(y);
if((coorx-2)>=1){
    if((coory-1)>=1){

        Console.WriteLine(table[(coorx-2)-1]+ " "+(coory-1));
    }
    if((coory+1)<=8){
        Console.WriteLine(table[(coorx-2)-1]+ " "+(coory+1));
    }
}
if((coorx+2)<=8){
    if((coory-1)>=1){
        Console.WriteLine(table[(coorx+2)-1] +" "+(coory-1));
    }
    if(coory+1<=8){
        Console.WriteLine(table[(coorx+2)-1] + " "+(coory+1));
    }
}
if((coory+2)<=8){
    if((coorx-1)>=1){
        Console.WriteLine(table[(coorx-1)-1]+ " "+(coory+2));
    }
    if((coorx+1)<=8){
        Console.WriteLine(table[(coorx+1)-1]+ " "+(coory+2));
    }
}
if((coory-2)>=1){
    if((coorx-1)>=1){
        Console.WriteLine(table[(coorx-1)-1]+ " "+(coory-2));
    }
    if((coorx+1)<=8){
        Console.WriteLine(table[(coorx+1)-1]+ " "+(coory-2));
    }
}

