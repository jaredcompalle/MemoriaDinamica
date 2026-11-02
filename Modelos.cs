namespace MemoriaDinamica;

/// <summary>CLASE = tipo por referencia. Sus instancias viven en el HEAP.</summary>
public class Persona
{
    public string Nombre;
    public int Edad;

    public override string ToString() => $"{Nombre} ({Edad} años)";
}

/// <summary>STRUCT = tipo por valor. Se copia completo (vive en el STACK cuando es variable local).</summary>
public struct PuntoValor
{
    public int X;
    public int Y;
}

/// <summary>Nodo de lista enlazada: cada nodo se reserva dinámicamente y apunta al siguiente.</summary>
public class Nodo
{
    public int Valor;
    public Nodo Siguiente;
    public byte[] Carga = new byte[100];   // relleno para que el consumo de memoria sea visible
}
