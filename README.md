# Taller1Scripting
 Aca esta la solución para el taller 1 de scripting
 Por : 
 Felipe Loaiza Martinez
 Daniel Muñoz Perez
 
 # El approach al taller
 
 Cada jugador tiene una lista de **Critters**, cada **Critter** tiene sus atributos correspondientes ademas de otro atributos que agregamos, que los llamamos bonuses que por defecto estan en 0, estos atributos representan un valor adicional, en ningun momento se modifica los atributos base del Critter, es en el getter del atributo base donde podemos obtener atributoBase + BonusAtributo. De esta manera podemos hacer que las SupportSkills aumenten stats con respecto a un porcentaje.
 **Skills**
 Ahora con respecto a las Skill de los Critter, los **Critters** al ser creado reciben por el constructor una lista de habilidades. Hay 2 tipo de Habilidades, el AttackSkill y las SupportSkill, por tanto se creo una clase abstracta Skill de la que heredan las dos, esta clase tiene un metodo abstracto lo que obliga a cada Clase que la herede a implementar el método. SupportSkill tambien es una clase abstracta, esta agrega las variables de porcentaje y MaxUses, ademas de que crea otro método abstracto, este método abstracto retorna el máximo de bonus que un Critter puede tener con respecto a un Atributo, esto nos facilita para que despues de un número de usos de una habilidad sobre un critter esta deje de tener efecto.
**Matriz de Afinidades y el Enum Affinity**
Las afinidades se guardaron en un enum llamado Afinidades en el siguiente orden.
**| Dark, Light, Fire, Water, Wind, Earth |** Este es el orden en que aparecen de izquierda a derecha en la matriz. Lo importante de hacerlo en orden es que si casteo el enum a un int me dara por ejemplo en Dark un valor de 0 y en Earth un valor de 5.
Por tanto ya podria crear una matriz de enteros 6 x 6 donde guardo los valores de la matriz tal como estan, en nuestro caso de la sgte manera (int)(affinity),(int)(enemyCritter.Affinity), donde el primer parametro es el affinity del ataque, y el segundo parametro es el affinity del target.
**Clase Stats** 
Para guardar los valores de la matriz de afinidades se creo una clase public y estatica llamada Stats, donde hay un getter publico estatico de la matriz anteriormente mencionada, se hizo de esta manera por que asumimos que ya en un escenario rear existiria un documento aparte donde estan los valores de la matriz, pero para efectos practicos de este ejercicio, lo declaramos en la clase Stats. Como conclusión a esto es que la clase stats como tal puede cambiar en un escenario real.

**Clase Combate**
Cada player lucha con los critter que tiene en la lista **critters**, pero si el critter pasa a 0 hp, pasa al jugador que lo vencio. Tambien en este ejercicio no se puede cambiar de critter en medio de la lucha, a diferencia de juegos como Pokemon donde es posible, por tanto para efectos practicos el combate, trabajamos con un Stack de critters para cada jugador.
La razón para que en clase combate exista un arreglo de tamaño 2 de Players y de StacksCritters>, es por lo siguiente: Para hacer facil el cambio de turno de un jugador a otro manejamos un contador que empieza en 0, como el tamaño de ambos arreglos es de 2, sus posiciones correspondientes seran 0 y 1. el contador ira aumentando cada turno hasta un maximo de 2,147,483,647 (que como tal dudo que sea posible alcanzarlo.) por tanto con el mod operator [contador % 2] estara entre 0 y 1.(Es como decir que los valores pares de contador es el turno del player1 y los impares del player2). El método **Turn** de la clase de combate recibe un número que corresponde a un skill de la lista de MoveSet de cada player. Con lo anterior dicho ya puedo saber a que jugador corresponde el turno, la criatura que hara la acción y el skill que usara.
Consideramos que es parte del Front End mostrar las Skills del critter en el Peek() del stack. Como por ejemplo en Dragon City que muestra las habilidades en varios botones, y cada uno de estos botones haria el método de turn con un diferente valor para el parametro skill, osea en pocas palabras en nuestra solución el front end se encarga de que el método turn se haga correctamente por el jugador correspondiente.
Luego de realizar el Skill, podemos revisar si el critter afectado fue vencido para luego sacarlo del stack, agregarselo a la colección del player que lo derroto, y quitarselo al player que lo poseia. Ademas luego se puede revisar si el Stack del enemigo es igual a 0, por lo que ya habria un ganador.

### El main se encuentra en la clase PruebasUnitarias



 
