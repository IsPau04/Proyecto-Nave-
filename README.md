# Proyecto-Nave-
proyecto realizado en c# con interfaz gráfica en visual studio 2022

instrucciones:
Simulador Sonda Espacial Ada
La administración nacional de aeronáutica y el espacio solicita su apoyo con el programa
de exploración espacial, para lo cual, le solicitan el desarrollo de un programa de
simulación para su nueva sonda espacial “Ada” que se encuentra en construcción. El
objetivo del software solicitado es experimentar con el comportamiento del vehículo antes
de enviarlo al espacio y analizar la información obtenida durante estas pruebas para
determinar las posibles rutas y cuáles son las más eficientes.
Descripción
El sistema debe simular el comportamiento de Ada cuando se desplaza en el espacio
exterior, simulado por un tablero cuadrangular en la pantalla que muestra la posición
actual del vehículo y los objetos astronómicos (planetas, asteroides) cercanos, así como
los objetos voladores no identificados (OVNI) que puedan cruzarse en su camino.
Imagen 1: Tablero de ejemplo
El Ada está diseñado para recolectar información en el espacio exterior. La comunicación
remota, desde la base hasta Ada, permite indicar una dirección de movimiento a la vez,
buscando un camino de regreso a la Tierra y así recolectar la información deseada. El
Facultad de Ingeniería
Departamento de Ciencias Básicas
Área de Programación
Introducción a la Programación
programa de simulación se utilizará para descubrir los caminos correctos e incorrectos
para que la aeronave regrese al planeta, además de recolectar información.
El diseño actual de la sonda únicamente le permite moverse en línea recta en una
dirección (adelante, atrás, izquierda o derecha), su movimiento se mantiene constante,
dada la inercia, siempre que no colisione con un asteroide, aterrice en la Tierra o se
detenga con un comando específico.
Todo espacio por el cual se desplazó Ada deja un trazo de ruta (marcado de un color
diferente) para poder visualizar la ruta que se ha tomado en todo momento.
Cuando el vehículo aterriza en la Tierra (la Tierra corta el paso del Ada) se considera una
“ruta correcta” y debe mostrar la cantidad de movimientos realizados desde el inicio de la
simulación, considerada como exitosa.
Imagen 2: ejemplo de una ruta correcta, simulación exitosa
Si luego de 10 movimientos, Ada no logra aterrizar en la Tierra, colisiona con un asteroide
o se usa el comando para detenerse, este continuará su ruta en línea recta hasta perderse
en el espacio no explorado. En este caso el programa debe mostrar un mensaje de “ruta
incorrecta” y reiniciar la simulación, ya que se considera como fallida.
Imagen 3: ejemplo de una ruta incorrecta, simulación fallida
Interfaz gráfica
Debe mostrar:
 Tablero
 Posición del Ada (1)
 Posición de los asteroides (0 o más)
 Posición de la Tierra (1)
 Estado de la simulación
o Nombre de la aeronave
Facultad de Ingeniería
Departamento de Ciencias Básicas
Área de Programación
Introducción a la Programación
o Número de iteración de la simulación
o Instrucciones
o Distancia recorrida (suma de los espacios recorridos, medida en
kilómetros)
o Combustible disponible
o Posición
o Trazo de ruta
Tablero
Es un espacio cuadrangular compuesto de múltiples espacios cuadrangulares menores.
Estos espacios menores se identifican por coordenadas de dos dimensiones: el Eje X y el
Eje Y. Todo tablero tiene una dimensión determinada MxN y todo lo que se encuentre
fuera de estos rangos se considera espacio no explorado, lugar donde el Ada se perderá y
provocará una simulación fallida.
Imagen 3: ejemplo de un tablero 4 x 4
Facultad de Ingeniería
Departamento de Ciencias Básicas
Área de Programación
Introducción a la Programación
Ada
Se ubica en un espacio libre del tablero. Marca la posición actual de la aeronave en la
simulación. Si el movimiento es interrumpido por la Tierra, el camino es correcto y termina
la simulación. Si el movimiento se interrumpe por choque con un asteroide o se llega al
espacio no explorado, el camino es incorrecto y la simulación se repite.
Imagen 4: marcador de la posición del Ada
Asteroide
Se ubican en un espacio aleatorio libre del tablero (es decir, uno donde no haya un objeto
astronómico). Marca las posiciones que el Ada no puede atravesar, provocando una
colisión si se acerca a su posición, el camino es incorrecto y la simulación se repite.
Imagen 5: marcador de la posición de un asteroide
Tierra
Se ubica en un espacio libre del tablero. Cuando el Ada llega al espacio marcado por la
Tierra la simulación termina y se establece que se encontró un camino correcto.
Imagen 6: marcador de la posición de la Tierra
Facultad de Ingeniería
Departamento de Ciencias Básicas
Área de Programación
Introducción a la Programación
Estado de la simulación
 Nombre de la aeronave: Se determina mediante el nombre del piloto, formándolo
como “GUA-“ + <Inicial del Apellido> + <ultima letra del Nombre>+ “-“ + <total de
letras de nombre y apellido>.
 Número de iteración de la simulación: Cada vez que se inicia una simulación, la
iteración por defecto es la “01”. Si una simulación es fallida, al reiniciar, aumenta el
número de iteración en una unidad (02, 03, etc.).
 Número de Instrucciones: cantidad de instrucciones de movimiento enviadas al
Ada (A = Avance, D= Detenerse, Restantes=R, se registran incluyendo aquellas que
se dan en la misma dirección y el comando para detenerse; las instrucciones
restantes dependen de la cantidad de combustible restante).
 Distancia recorrida: sumatoria de los espacios recorridos (se incluyen aquellos que
se hagan por un espacio que ya se ha recorrido anteriormente), cada espacio
recorrido equivale a 1000 KmApe
 Combustible disponible: El Ada comienza con el 100.0% (real redondeado a 1
decimal) de combustible, que le permite cubrir hasta el 40% (entero acotado) del
tablero (Combustible inicial = Acotar(0.4(M*N))). Con cada instrucción ejecutada,
debe mostrarse el combustible restante (en forma porcentual decreciente); cada
instrucción para detenerse consume el doble de combustible que una instrucción
de movimiento.
 Posición: Ubicación en el Eje X y Eje Y del Ada
 Trazo de ruta: Describe la ruta efectuada mostrando el camino tomado por el Ada
hasta que la simulación finalice o se reinicie.
Facultad de Ingeniería
Departamento de Ciencias Básicas
Área de Programación
Introducción a la Programación
Ada GUA-CN-14
Iteración 01
Instrucciones
5 A
1 D
9 R
Recorrido 13000 Km
Combustible 56.3%
Posición (5,4)
Imagen 8: ejemplo de tabla del estado de la simulación
Ventanas
Inicio
Al iniciar el programa se debe mostrar una pantalla con las siguientes opciones:
1. Iniciar simulación
a. Tablero: solicita las dimensiones M y N del tablero.
b. Asteroides: solicita el número de asteroides que aparecerán en forma
aleatoria en el tablero, en un rango entre 0 – 60% (entero acotado) de la
dimensión MxN del tablero.
c. Tierra: posición en el Eje X y Eje Y de la Tierra.
d. OVNI: solicita el número de OVNI que aparecerán en forma aleatoria en el
tablero, en un rango entre 0 – 20% (entero acotado) de la dimensión MxN
del tablero.
e. Ada: posición en el Eje X y Eje Y del Ada.
f. Inicia la simulación
2. Instrucciones
a. Muestra una ventana con los comandos utilizados durante la simulación.
3. Salir
a. Finaliza el programa
Pantalla de simulación
1. Al iniciar la simulación debe solicitar el nombre del piloto y su apellido, estos datos
deben mostrarse en pantalla en todo momento y adicionalmente se utilizarán para
generar el nombre de la nave.
2. Luego deberá permitir iniciar la simulación y mostrar el tablero.
3. Debe haber una opción en pantalla para poder reiniciar la simulación (en cualquier
momento y de forma automática al tener una simulación fallida).
4. Controles durante la simulación:
a. Flecha arriba: desplazar la nave hacia arriba hasta que un objeto la
detenga.
b. Flecha abajo: desplazar la nave hacia abajo hasta que un objeto la detenga.
Facultad de Ingeniería
Departamento de Ciencias Básicas
Área de Programación
Introducción a la Programación
c. Flecha derecha: desplazar la nave hacia la derecha hasta que un objeto la
detenga.
d. Flecha izquierda: desplazar la nave hacia ala izquierda hasta que un objeto
la detenga.
e. Detenerse: designar una tecla para ejecutar el comando de instrucción para
detenerse.
5. Cuando se complete una simulación exitosa, se mostrará la opción “Grabar
simulación”.
6. Cuando la nave se pierde debe mostrar un mensaje de misión fallida y dar opción a
reiniciar la simulación (antes debe mostrarse la opción “Grabar simulación”) o a
salir al menú principal.
