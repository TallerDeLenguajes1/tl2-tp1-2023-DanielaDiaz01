namespace EmpresaCadeteria;

public enum EstadoPedido
{
    Entregado,
    Pendiente
}

public class Pedido
{
    private int numero;
    private string observacion;
    private Cliente cliente;
    private EstadoPedido estado;

    public Pedido(int numero, string observacion, EstadoPedido estado, string nombre,string direccion, string telefono, string datosReferenciaDireccion)
    {
        this.numero = numero;
        this.observacion = observacion;
        this.cliente = new Cliente(nombre, direccion, telefono, datosReferenciaDireccion);
        this.estado = estado;
    }

    public int Numero { get => numero; set => numero = value; }
    public string Observacion { get => observacion; set => observacion = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public EstadoPedido Estado { get => estado; set => estado = value; }

//Metodos
    public void VerDireccionCliente(){
        Console.WriteLine("\n---Direccion del cliente---\n");
        Console.WriteLine($"> Direccion: {cliente.Direccion}");
    }

    public void VerDatosCliente(){
        Console.WriteLine("\n---Datos del cliente---\n");
        Console.WriteLine($"> Direccion: {cliente.Nombre}");
        Console.WriteLine($"> Direccion: {cliente.Direccion}");
        Console.WriteLine($"> Direccion: {cliente.Telefono}");
        Console.WriteLine($"> Direccion: {cliente.DatosReferenciaDireccion}");
    }


    public void CambiarEstado(EstadoPedido estado){
        switch (estado)
        {
            case EstadoPedido.Entregado:
                estado = EstadoPedido.Pendiente;
                break;

            case EstadoPedido.Pendiente:
                estado = EstadoPedido.Entregado;
                break;
        }  
    }
    
    

}