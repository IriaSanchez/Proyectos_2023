import 'package:flutter/material.dart';

void main() {
  runApp( Calculadora());

}



class Calculadora extends StatelessWidget {
@override
Widget build(BuildContext context) {

  return MaterialApp(
    title: "Calculadora",
    home: Scaffold(
        appBar: AppBar(),
          body: Padding(
            padding: const EdgeInsets.all(50),
            child: Column(
              children: [
                  Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [

                     Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,

                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),                     
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_7_outlined) , 
                      
                      onPressed: (){
                      recogerNumero("7");
                      },
                      
                      ),

                    ),
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_8_outlined) ,

                      onPressed: (){
                      recogerNumero("8");
                      },
                      
                      ),

                    ),
                    
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                    height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_9_outlined) ,

                      onPressed: (){
                      recogerNumero("9");
                      },
                      
                      ),
                    ), 
                    
                     Container(
                      decoration: BoxDecoration(
                      color: Colors.green[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Text("+", textAlign: TextAlign.center,style: TextStyle(fontSize: 20,color: Colors.black),) , 
                      
                      onPressed: (){
                      String operador="+";
                      recogerOperador(operador);
                      },
                      
                      ),
                    ),           
                  ],
                ),


                  Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [


                     Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                     height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_4_outlined) , 
                      
                      
                      onPressed: (){
                      recogerNumero("4");
                      },
                      
                      ),

                    ),
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_5_outlined) , 

                      onPressed: (){
                      recogerNumero("5");
                      },
                      
                      ),
                    ),
                    
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_6_outlined) ,
                      
                      onPressed: (){
                      recogerNumero("6");
                      },
                      
                      ),

                    ),
                    
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.green[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Text("-", textAlign: TextAlign.center,style: TextStyle(fontSize: 20,color: Colors.black),) , 
                      
                      onPressed: (){
                      String operador="-";
                      recogerOperador(operador);
                      },
                      
                      ),
                    ),           
                  ],
                ),

                  Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [

                     Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_1_outlined) , 

                      onPressed: (){
                      recogerNumero("1");
                      },
                      
                      ),
                    ),

                      Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_2_outlined) , 

                      onPressed: (){
                      recogerNumero("2");
                      },

                      ),
                    ), 
                    
                     Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.filter_3_outlined) , 

                      onPressed: (){
                      recogerNumero("3");
                      },

                      ),
                    ),
                    
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.green[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                     height: 80,
                      width: 100,
                      child: IconButton(icon: Text("*", textAlign: TextAlign.center,style: TextStyle(fontSize: 20,color: Colors.black),) ,
                      
                       onPressed: (){
                       String operador="*";
                       recogerOperador(operador);
                       },
                       
                       ),
                    ),           
                  ],
                ),

                  Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [

                     Container(
                      decoration: BoxDecoration(
                      color: Colors.green[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.close) , 

                    //Llamamos a la función reiniciar para que todas las variables sean 0 y se pueda comenzar una nueva operación al pulsar el icono de reset
                      onPressed: (){
                      reiniciar();
                      print("Has reiniciado la calculadora. Introduce una nueva operación.");
                      },
                      
                      ),
                    ),


                      Container(
                      decoration: BoxDecoration(
                      color: Colors.blue[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Icon(Icons.exposure_zero) , 

                      onPressed: (){
                      recogerNumero("0");
                      },
                      
                      ),
                      ),

                    
                    
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.green[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Text("=", textAlign: TextAlign.center,style: TextStyle(fontSize: 20,color: Colors.black),) ,
                      
                       onPressed: (){
                     
                      calcularResultado();

                       },
                       
                       ),
                    ),
                    
                      Container(
                      decoration: BoxDecoration(
                      color: Colors.green[100],
                      shape: BoxShape.rectangle,
                      border: Border.all(
                      color: Color.fromARGB(255, 90, 112, 91),
                      width: 4,
                      ),
                      ),
                      height: 80,
                      width: 100,
                      child: IconButton(icon: Text("/", textAlign: TextAlign.center,style: TextStyle(fontSize: 20,color: Colors.black),) , 
                      
                      onPressed: (){
                       String operador="/";
                       recogerOperador(operador);
                       },
                     
                      ),
                    ),           
                  ],              
              ) ,
            ]
),
          )
          )

);
}






     // Variables : primer string para el primer numero (que puede tener mas de un digito)
      //Segundo string para el numero por el que se va a sumar, restar, multiplicar, etc
      //operador = restar,sumar, etc;

       String numero1 = "";
       String numero2 = "";
       String op = "";
       int num1 = 0;
       int num2 = 0;
       double resultado = 0;








     //Metodo que recoge los numeros que van a sumarse, dividirse, etc;
     //Se le indica qye mientras no exista operador, es decir, que esté vacío, significa que los siguientes numeros forman parte del primer numero o del segundo,
     //es decir, es un numero de varias cifras y le pedimos concatenarlas

       void recogerNumero (String num){

          if (op == "") {         
          numero1 = numero1 + num;

         }else{
          numero2 = numero2 + num;
         }
      }








     //Método que recoge el operador
     //Se le indica que el string operador es el mismo que declaramos antes, llamado op

     void recogerOperador (String operador){

      op = operador;

     }








    //Método que calcula el resultado
    //Como los numero1 y numero2 son String, hay que parsearlos a int (declarados anteriormente como num1 y num2)

     void calcularResultado (){

      num1 = int.parse(numero1);
      num2 = int.parse(numero2);
    
     //Con el if añadimos todas las operaciones
     //El resultado, declarado anteriormente como double, es la operacion entre ambos numeros y se castea (ya que son int y no double)

      if(op == "*"){
        resultado = (num1*num2) as double;
    
      }if (op == "-"){
        resultado = (num1-num2) as double;

      }if (op == "/"){
        resultado = (num1/num2) as double;

      }if (op == "+"){
        resultado = (num1+num2) as double;
      }

      //Imprimimos por pantalla el resultado de la operación:
       print ("El resultado de " +numero1+ " " +op+ " " +numero2+  " es igual a: " );
       print(resultado);

      //Llamamos al método reiniciar
      //Con esto conseguimos que el resultado se convierta en el primer operando para la siguiente operación
      reiniciar();
      numero1 = resultado.toString();      
     }








    //Con el método reiniciar conseguimos reiniciar todas las variables excepto el resultado que se convertirá en el primer numero

     void reiniciar () {

        numero1 = "";
        numero2= "";
        op = "";
        num1=0;
        num2=0;      
     }  
}