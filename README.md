# CsharpExam
Responder las siguientes preguntas:

1-¿C# permite herencia múltiple?
2-¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
3-¿Qué implica una relación de Generalización entre dos clases?
4-¿Qué implica una relación de Implementación entre una clase y una interfaz?
5-¿Qué diferencia hay entre la relación de Composición y la Agregación?

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual. [Verdadero]

Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. [Falso]

Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. [Falso]

1- La herencia multiple no esta permitida en C#

2- La herencia se debe utilizar para expresar relaciones que se lean "es un tipo de", mientras que las interfaces las podemos utilizar para expresar relaciones de la forma "se comporta como". Hay que tener en cuenta que c# no permite herencia multiple, pero si podemos implementar múltiples interfacer en una clase.Ejemplo:

Tenemos la clase documento, que es superclase de las subclases documentoWord, y documentoPDF. Ambos son un tipo de documento. Ahora podriamos definir la interfaz Iimprimible, en ella declarar el método imprimir, y reescribirlo en nuestras subclases documentoWord, y documentoPDF, para que estos se comporten como Imprimibles, y cada uno redefina el método de la manera mas conveniente.

3- Una relacion de Generalizacion implica que el elemento especifico (subclase) es un tipo de el elemento general (superclase). La subclase, heredará los métodos y atributos de la clase padre, y a su vez, podrá definir nuevos.

4- Implica que la clase "se comporta como" la interfaz, la interfaz es una clase de contrato. La interfaz define los metodos ,los tipos de retorno, y los tipos y cantidad de parámetros que debe recibir cada clase que implemente la interfaz. La interfaz no define implementaciones 

5- En la composicion, las partes solo existen asociadas al compuesto ( Solo se accede a ellas a traves de el), cuando el todo se elimina, las partes deben ser eliminadas, ya que no tendrian sentido independientemente.
