//CREAR LISTA DE NOMBRES
List<string> NAMES = new List<string> ();

//CREAR LISTA DE PUNTOS
List<int> POINT = new List<int>();

//CREAR LAS LISTAS BASE (BAQUEIRA BERET/FIERBRUNN/YETI EXTREME)

//BAQUEIRA
List<string> BAQUEIRA = new List<string>()
{
    "Jonathan Penfield",
    "Liam Rivera",
    "Katie Anderson",
    "Anna Orlova",
    "Ludovic Guillot​",
    "​Estelle Rizzolio",
};
List<int> BAQUEIRAPOINT = new List<int>();
{ 
// Añadir elementos a la lista
BAQUEIRAPOINT.Add(500);
BAQUEIRAPOINT.Add(400);
BAQUEIRAPOINT.Add(300);
BAQUEIRAPOINT.Add(150);
BAQUEIRAPOINT.Add(100);
BAQUEIRAPOINT.Add(150);
}

//FIERBRUNN
List<string> FIERBRUNN = new List<string>()
{
    
    "Katie Anderson",
    "Liam Rivera​",
    "Anna Orlova ",
    "Estelle Rizzolio", 
    "Jonathan Penfield", 
    "Ludovic Guillo",
};
List<int> FIERBRUNNPOINT = new List<int>();
{
    // Añadir elementos a la lista
    FIERBRUNNPOINT.Add(500);
    FIERBRUNNPOINT.Add(400);
    FIERBRUNNPOINT.Add(300);
    FIERBRUNNPOINT.Add(150);
    FIERBRUNNPOINT.Add(100);
    FIERBRUNNPOINT.Add(150);
}


object value = BAQUEIRA + BAQUEIRAPOINT.ForEach(Console.WriteLine);



//RECORRER CADA UNA DE LAS LISTAS Y COMPROVAR EL VALOR DE CADA PERSONA Y ORDENAR DE MAYOR A MENOR
//IMPRIMIR POR PANTALLA LA LISTA DE NOMBRES + LISTA DE PUNTOS