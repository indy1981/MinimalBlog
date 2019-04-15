La solucion se implemento en .NET Core y SQL por lo que se necesita un servidor de base de datos corriendo 
Hay una API con lo minimo requerido y una UI que la consume, obviamente ambos proyectos deben estar corriendo a la vez 
La UI fue hecha solo a fines de poder consumir la api y la autenticacion, favor de no evaluar estetica

Se debe ejecutar:
dotnet ef database update --startup-project ..\MinimalBlog

desde el directorio MinimalBlog.Repositories para que se creen las tablas y los datos iniciales

Los usuarios para ingresar son:
Username: adrian
Password: makingsense@99

Username: juan
Password: minimal@123

Se crearon 2 para ver que los post privados y draft solo son visibles por su autor

Por falta de tiempo, solo implemente algunos tests basicos, como para que se vea la mecanica, en un entorno real, se necesitan mas test unitarios, de integracion y mas significativos (o sea no solo cubrir codigo por cubrir)
La parte de los estados del post que considere mas apropiada es asi:

Un post siempre debe tener un titulo
Se puede grabar un post sin summary o content, pero si falta alguno de estos campos o ambos, sera guardado si o si como Draft
Para que un post sea considerado completo (NO-draft) debe tener como minimo
	title
	summary
	content

En cuyo caso, se tomara el estado (public o private) que haya establecido el autor.
El autor del post siempre es el usuario logueado, por lo que no se envia desde la UI sino que se toma de los claims del token enviado
La fecha de creacion es la actual del servidor siempre

Cosas que faltaron: 
Un mapper para pasar de viewmodels a modelos
Mas testing
Update y delete de los post del usuario logueado, si bien estas acciones estan la API no hay una funcionalidad en la UI que haga uso de ellos (habria hecho una pantalla con una tabla con acciones sobre ellos, o bien acciones en cada post en el index)
Mas ajax, no tantas pantallas de error, si no quizas algo tipo bootbox para informar de errores (por ejemplo usuario o contraseña invalida)
Alguna pantalla de un admin para administrar usuarios
Falto la busqueda, se podria haber implementado haciendo otro metodo del servicio buscando en title, summary y content por palabras o bien permitiendole agregar tags al creador del post y buscar en ambos lados
