# Usodedelegados

# Explicación del problema

Se hizo una calculadora en consola que puede sumar, restar, multiplicar y dividir. La idea es que el programa ejecute la operación que el usuario elija, pero sin usar muchos if, sino algo más flexible.

# Definición de delegados

Un delegado es básicamente una variable que puede guardar un método. O sea, en vez de guardar números o texto, guarda una función para usarla después.

# ¿Por qué usar delegados en vez de llamar métodos directamente?

Porque hace el código más ordenado y fácil de manejar. En lugar de tener muchas condiciones para decidir qué hacer, el delegado ya tiene guardada la operación que se va a ejecutar. Así también es más fácil agregar nuevas operaciones después.

# Cómo se implementaron en el proyecto (pasos)
Se creó un delegado llamado CalculoMatematico que recibe dos números.
Se hicieron los métodos para sumar, restar, multiplicar y dividir.
Se usó un diccionario para relacionar palabras como "sum" o "mul" con cada operación.
El usuario escribe los números y la operación que quiere.
El programa busca la operación y la guarda en el delegado.
El delegado ejecuta el cálculo y muestra el resultado.

# Ejemplo de uso (entrada y salida)

# Entrada:
Ingrese la primera cantidad: 10

Elija operación (sum, res, mul, div): sum

Ingrese la segunda cantidad: 5

# Salida:
El resultado final es: 15

<img width="1059" height="759" alt="image" src="https://github.com/user-attachments/assets/f6125671-d213-4455-b5e1-1b9e4da3d178" /> 
En esta parte se crea el delegado CalculoMatematico, que permite guardar cualquier operación matemática que reciba dos números.
También están los métodos que realizan los cálculos: suma, resta, multiplicación y división. En la división se valida que no sea entre cero para evitar errores.

<img width="1264" height="413" alt="image" src="https://github.com/user-attachments/assets/9037fcb1-d453-4ab2-8188-f5280d9adbd4" />
Aquí se crea un diccionario que relaciona una palabra (como "sum" o "mul") con cada operación.
Esto permite elegir qué método ejecutar sin usar muchos if, haciendo el código más limpio y fácil de ampliar.

<img width="927" height="320" alt="image" src="https://github.com/user-attachments/assets/14303808-09e6-40fe-9660-f7af7a39c10a" />
En esta parte el usuario ingresa los datos: dos números y la operación que quiere realizar.
Los valores se convierten a double para permitir trabajar con números decimales.

<img width="1484" height="632" alt="image" src="https://github.com/user-attachments/assets/d3817e1d-3559-46d2-bfc6-c9373b755322" />
Aquí el programa verifica si la operación existe.
Si existe, se guarda en el delegado y se ejecuta con los números ingresados. Luego se muestra el resultado.
Si no existe, se muestra un mensaje de error.

# Resultado Final:
<img width="778" height="375" alt="image" src="https://github.com/user-attachments/assets/9fa637ac-e189-463d-95fc-3e8b60c30436" />





