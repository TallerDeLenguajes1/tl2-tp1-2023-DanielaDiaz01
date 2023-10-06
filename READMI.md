**¿Cual de estas relaciones considera que se realiza por composicion y cual por agregacion?**
Cadete-Cadetería: agregacion
Cadete-Pedido: agregacion
Pedido-Cliente: composicion 

**¿Qué métodos consideran que debería tener la clase Cadetería y la clase Cadete?**
Clase Cadeteria:
    AltaPedido(),
    AsignarPedidoCadete(),
    MostrarInforme(),
    MostrarCantidadPedidosCadetes(),
    CambiarEstadoPedido(),
    ReasignarPedidoAOtroCadete()

Clase Cadete:
    MontoDiaCobrar(),
    AgregarPedido(),
    CambiarEstadoPedido(),
    eliminarPedido(),
    QuitarPedido()

**Teniendo en cuenta los principios de abstraccion y ocultamiento, que atributos, propiedades y metodos deben ser publicos y privados**
Clase Cliente
    Privados: Los datos personales como nombre, telefono, direccion, etc

Clase Pedido
    Privados: Datos principales como numero, observaciones y estado de cada pedido
    Publico: Metodos VerDatosCliente() y Entregado()

Clase Cadete
    Privado: Datos personales como nombre, direccion, telefono
    Publicos: Los metodos de la clase

**¿Como diseñaria los constructores de cada una de las clases?**


