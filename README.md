# CleanArchitectureASPNet
Proyecto en ASPNet Core usando Clean Architecture

Para que te funcione este proyecto.

Coloca una cadena de conexion valida en el archivo app.settings.Development.json. Te dejo esta de ejemplo:
"ConexionDB": "Data Source=localhost\\SQLEXPRESS;Initial Catalog=tu_base_Datos;User=admin;Password=tu_password;TrustServerCertificate=true"

Despues. Abre la ventana de consola de administración de pquete nugets y actualiza la BD. Ejecuta el comando:

> Update-Database

Este creará la base de datos en el servidor especificado en la cadena de conexion.
