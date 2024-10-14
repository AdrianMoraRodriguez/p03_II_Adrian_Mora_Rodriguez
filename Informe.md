# Práctica 3: Físicas
## Situaciones
1. El plano no es un objeto físico. El cubo es un objeto físico y la esfera no. En este caso, el plano y la esfera sólo tendrán collider, mientras que el cubo debe tener Rigidbody.   
El cubo caerá debido a la gravedad, ya que tiene un Rigidbody y colisionará con el plano. Como el plano no es físico (sin Rigidbody), solo servirá como una superficie estática. La esfera, al no tener Rigidbody, no se verá afectada por la gravedad ni las físicas, quedará en su lugar sin moverse ni interactuar físicamente con el cubo o el plano.  
![Sit 1](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit1.gif)  
***
2. El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody. 
Tanto el cubo como la esfera caerán por la gravedad. Ambos objetos tendrán interacciones físicas. El cubo caerá y colisionará con el plano. La esfera también colisionará con el plano.  
![Sit 2](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit2.gif) 
***
3. El plano no es un objeto físico. El cubo es un objeto físico y la esfera es cinemática. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody esta última cinemático.  
El cubo caerá debido a la gravedad y colisionará con el plano. Sin embargo, la esfera, al ser cinemática, no será afectada por las fuerzas físicas.   
![Sit 3](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit3.gif) 
***
4. El plano es un objeto físico. El cubo es un objeto físico y la esfera es física. En este caso, todos los objetos deben tener Rigidbody. 
En este caso, todos los objetos están sujetos a las físicas. El cubo y la esfera caerán y colisionarán tanto con el plano como entre ellos mismos. E plano se mueve cayendo.  
![Sit 4](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit4.gif) 
***
5. El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 10 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.  
La esfera, al tener más masa, será más pesada, lo que afectará las interacciones. Tanto la esfera como el cubo caerán sobre el plano que también caerá, pero si colisionan, la esfera ejercerá mucha más fuerza sobre el cubo debido a su masa. El cubo se moverá más fácilmente cuando interactúe con la esfera, que será más difícil de mover.  
![Sit 5](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit5.gif)  
***
6. El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 100 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.  
La esfera, al ser muchísimo más pesada, dominará las interacciones físicas. El cubo prácticamente no podrá moverla, y si ambos colisionan, la esfera probablemente empujará al cubo de manera significativa.  
![Sit 6](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit6.gif)  
***
7. El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con fricción. En este caso, todos los objetos deben tener Rigidbody.  
El cubo, la esfera y el planp caerán. La fricción en la esfera afectará su movimiento. Si tiene mucha fricción, será difícil que la esfera se deslice, ruede o, incluso, caiga ya que la fricción la detendrá rápidamente.  
![Sit 7](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit7.gif)  
***
8. El plano es un objeto físico. El cubo es un objeto físico y la esfera no es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.  
La esfera no colisionará de manera física con otros objetos. Actuará como un Trigger, lo que significa que puede detectar cuándo otros objetos la atraviesan, pero no causará una colisión física. El cubo y el plano interactuarán normalmente con las físicas.  
![Sit 8](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit8.gif)  
***
9. El plano es un objeto físico. El cubo es un objeto físico y la esfera es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.  
El cubo y el plano interactuarán normalmente con las físicas. La esfera, aunque tiene Rigidbody, no colisionará físicamente porque está marcada como Trigger.  
![Sit 9](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/sit9.gif) 

## Ejercicios
1. Agrega un campo velocidad a un cubo y asígnale un valor que se pueda cambiar en el inspector de objetos. Muestra la consola el resultado de multiplicar la velocidad por el valor del eje vertical y por el valor del eje horizontal cada vez que se pulsan las teclas flecha arriba-abajo ó flecha izquierda-derecha. El mensaje debe comenzar por el nombre de la flecha pulsada.   
![ej 1](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej1.gif)  
***
2. Mapea la tecla H a la función disparo. 
Se ha creado un nuevo Input para el disparo y se le ha asignado la tecla h.  
![ej 2](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej2.PNG) 
***
3. Crea un script asociado al cubo que en cada iteración traslade al cubo una cantidad proporcional un vector que indica la dirección del movimiento: moveDirection que debe poder modificarse en el inspector.  La velocidad a la que se produce el movimiento también se especifica en el inspector, con la propiedad speed. Inicialmente la velocidad debe ser mayor que 1 y el cubo estar en una posición y=0. En el informe de la práctica comenta los resultados que obtienes en cada una de las siguientes situaciones:  

a) duplicas las coordenadas de la dirección del movimiento.  
Si duplicas moveDirection, el cubo se moverá el doble en la misma dirección.  
b) duplicas la velocidad manteniendo la dirección del movimiento.  
Si duplicas speed, el cubo se moverá más rápido, pero en la misma dirección.  
c) la velocidad que usas es menor que 1  
Si la velocidad es menor a 1, el cubo se moverá más lentamente.  
d) la posición del cubo tiene y>0  
Si el cubo tiene una posición con y > 0, se moverá pero no regresará automáticamente al suelo.  
e) intercambiar movimiento relativo al sistema de referencia local y el mundial.  
Al cambiar entre el sistema de referencia local y global, notarás que el cubo se mueve en diferentes direcciones según su rotación.  
![ej 3](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej3.gif) 
***
4. Mueve el cubo con las teclas de flecha arriba-abajo, izquierda-derecha a la velocidad speed. Cada uno de estos ejes implican desplazamientos en el eje vertical y horizontal respectivamente. Mueve la esfera con las teclas w-s (movimiento vertical) a-d (movimiento horizontal).  
Se ha creado dos nuevos inputs: HorizontalSphere y VericalSphere para obtener el movimiento de la esfera.  
![ej 4](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej4.gif) 
***
5. Adapta el movimiento en el ejercicio 4 para que sea proporcional al tiempo transcurrido durante la generación del frame.  
Al Script anterior se ha añadido Time.Deltatime para tener en cuenta el tiempo.  
![ej 5](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej5.gif)  
***
6. Adapta el movimiento en el ejercicio 5 para que el cubo se mueva hacia la posición de la esfera. Debes considerar, que el avance no debe estar influenciado por cuánto de lejos o cerca estén los dos objetos. 
Se ha normalizado la distancia entre los puntos y se hace que el cubo se mueva hacia esa dirección.  
![ej 6](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej6.gif)  
***
7. Adapta el movimiento en el ejercicio 6 de forma que el cubo gire hacia la esfera. Realiza pruebas cambiando la posición de la esfera mediante las teclas awsd  
Se ha utilizado la función LookAt y el Vector3.forward para que mire hacia la esfera y se mueva hacia adelante.  
![ej 7](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej7.gif)  
***
8. Utilizar el eje “Horizontal” para girar el objetivo y que avance siempre en la dirección hacia adelante.  
Para esto se ha utilizado Quaternion.Slerp para modificar la orientación de manera sueve y se ha usado el transform.forward.  
![ej 8](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej8.gif)  
***
9. Configura el cilindro como un objeto físico, cuando el cubo o la esfera colisionen con él se debe mostrar un mensaje en consola con la etiqueta del objeto que haya colisionado.  
Para ello se ha marcado el cubo y la esfera como IsTrigger y se ha utilizado la función OnTriggerEnter.  
![ej 9](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej9.gif) 
***
10. Configura el cubo como un objeto cinemático y la esfera como un objeto físico. Adapta los scripts del ejercicio 9 para obtener el mismo comportamiento.  
En este caso se ha cambiado el script para que sea un OnCollisionEnter. Además para el movimiento de la esfera se ha adaptado el script para que sea un movimiento físico con AddForce y FixedUpdate.  
![ej 10](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej10.gif) 
***
11. Configura el cilindro como un objeto de tipo Trigger. Adapta los scripts de los ejercicios anteriores para obtener el mismo comportamiento.  
Como el cilindro es IsTrigger, se ha utilizado la función OnTriggerEnter.  
![ej 11](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej11.gif) 
***
12. Agrega un cilindro de un color diferente al que ya hay en la escena y configúralo como un objeto físico. Selecciona un conjunto de teclas que te permitan controlar su movimiento por la escena y prográmale un movimiento que permita dirigirlo hacia la esfera. Prueba diferentes configuraciones de la esfera física con masa 10 veces mayor que el cilindro, física con masa 10 veces menor que el cilindro, cinemática y trigger. También prueba la configuración del cilindro de forma que su fricción se duplique o no. Explica en el informe todos los resultados posibles.   
a) Esfera con masa 10 veces mayor: El cilindro es significativamente afectado por la colisión, mientras que la esfera apenas se mueve.  
b) Esfera con masa 10 veces menor: La esfera es empujada fácilmente por el cilindro, que apenas se ve afectado.  
c) Esfera cinemática: La esfera no se ve afectada por colisiones físicas, pero puede frenar o redirigir el movimiento del cilindro.  
d) Esfera trigger: El cilindro atraviesa la esfera sin ninguna interacción física, pero se pueden ejecutar eventos de detección.  
e) Cilindro con fricción duplicada: El movimiento del cilindro es más difícil y lento debido a la mayor resistencia en el suelo y las colisiones.  
![ej 12](https://github.com/AdrianMoraRodriguez/p03_II_Adrian_Mora_Rodriguez/blob/main/Multimedia/ej12.gif) 