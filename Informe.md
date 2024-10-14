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
***
