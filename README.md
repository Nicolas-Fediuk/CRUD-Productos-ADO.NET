Proyecto realizado con el proposito de apreden ADO .NET

### Hablidades
- C#
- .NET 6
- Libreria Krypton
- Programación en capas
- ADO .NET
- SQL Server

# 

### Inicio

![](https://github.com/Nicolas-Fediuk/CRUD-Productos-ADO.NET/blob/master/imgReadme/inicio.png?raw=true)

Al iniciar el programa se carga este form. 
- Bonton "Nuevo":  Se carga otro formulario para ingresar un nuevo producto
- Boton "Editar": Primero se debe seleccionar el articulo a editar en la tabla de arriba, cuando la fila este en blanco es la seleccionada, luego dar click en este mismo boton
- Boton "Eliminar": Primero se debe seleccionar el articulo en la tabla de arriba, cuando la fila este en blanco es la seleccionada, luego dar click en este mismo boton para eliminarlo
- Boton "Resfrescar": Actualiza la tabla

### Agregar / Editar

![](https://github.com/Nicolas-Fediuk/CRUD-Productos-ADO.NET/blob/master/imgReadme/agregarEditar.png?raw=true)

Tanto para agregar un nuevo producto como para editar uno se carga el mismo formulario.
- Cuando se agregar un nuevo producto se le agregar el nombre y el precio. **Si se agregar un producto con el mismo nombre de uno ya cargado este no se cargará y se le advertira con un cartel y el precio no puede ser igual a 0**
- Cuando se edita un producto este no tiene que igual a ya uno cargado, en caso contrario este no se cargará y se le advertira con un cartel, y el precio no puede ser igual a 0.
