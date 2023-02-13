package org.example;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;


public class App {
   static boolean finpartida = false;

    public static void main(String[] args) throws IOException, SAXException {


        Scanner teclado = new Scanner(System.in);
        ArrayList<Aventura> arrayAventura = new ArrayList<Aventura>();

        int opcionAventura = 0;
        String ruta = "";


        try {
            do {

            System.out.println("¿A qué aventura quieres jugar?");
            System.out.println();
            System.out.println("1-THE LOST CITY - VERSION LA CORUÑA");
            System.out.println("2-THE LOST CITY - VERSION NEW YORK");




                opcionAventura = teclado.nextInt();



                if (opcionAventura == 1) {

                    ruta = "C:\\Users\\FP\\Documents\\GitHub\\IriaSM\\AD\\Aventura\\Aventura_LCG.xml";

                }else if (opcionAventura == 2) {

                    ruta = "C:\\Users\\FP\\Documents\\GitHub\\IriaSM\\AD\\Aventura\\Aventura_NY.xml";



                }else{
                    System.out.println("La opción escogida no existe.");
                    System.out.println("Inténtalo de nuevo:");
                    System.out.println();
                }

            }while (opcionAventura !=1 && opcionAventura !=2);

            //Creamos la instancia de DocumentBuilderFactory y DocumentBuilder
            //SIEMPRE LAS MISMAS
            DocumentBuilderFactory fabricaCreadorDocumento = DocumentBuilderFactory.newInstance();
            DocumentBuilder creadorDocumento = fabricaCreadorDocumento.newDocumentBuilder();
            //Creamos instancia de Document indicando el fichero que debe parsear
            //Objeto de tipo documento donde le pasamos la ruta del documento xml en nuestro ordenador
            Document documento = (Document) creadorDocumento.parse(ruta);
            //Obtener el elemento raiz del documento
            Element raiz = documento.getDocumentElement();
            documento.getDocumentElement().normalize();


            //Creamos el elemento aventura que es la raiz
            Element elementoAventura = (Element) raiz;
            //Dentro del elemento raiz aventura, sacamos el atributo título
            Node nodoTitulo = elementoAventura.getAttributeNode("titulo");
            //Imprimimos el titulo de la aventura
            String valTitulo = (nodoTitulo != null) ? nodoTitulo.getTextContent() : null;

            //System.out.println("************************************");
           //System.out.println( valTitulo);
           //System.out.println("************************************");





            //De la lista de aventura, recogemos el elemento escena
            NodeList listaAventura = raiz.getElementsByTagName("escena");


            //ArrayList de escena
            ArrayList<Escena> escenas = new ArrayList<Escena>();

            //Recorremos toda la listaAventura

            for (int i = 0; i < listaAventura.getLength(); i++) {


                //Creamos el nodo escena
                Node nodoEscena = listaAventura.item(i);
                //  System.out.println("Escena: " + i);

                //Creamos el elemento escena
                Element elementoEscena = (Element) nodoEscena;

                //Dentro del elemento escena, sacamos el atributo codigo
                Node nodoCodigo = elementoEscena.getAttributeNode("codigo");
                //Imprimimos el código de la aventura
                String valCodigo = (nodoCodigo != null) ? nodoCodigo.getTextContent() : null;
                //  System.out.println("Codigo: " + valCodigo);


                //Creamos la lista de todos los datos del elemento del nodo escena
                NodeList datosAventura = nodoEscena.getChildNodes();

                //Dentro del elemento escena, sacamos el elemento texto
                Node nodoTexto = elementoEscena.getElementsByTagName("texto").item(0);
                String valTexto = (nodoTexto != null) ? nodoTexto.getTextContent() : null;
                //System.out.println("//////////////////////////////////////////////////");
                //System.out.println("Texto: " + valTexto);
                //System.out.println("//////////////////////////////////////////////////");


                //De la lista de escena, recogemos el elemento opcion
                NodeList listaOpciones = elementoEscena.getElementsByTagName("opcion");

                ArrayList<Opcion> opciones = new ArrayList<Opcion>();

                //Recorremos la lista de opciones
                for (int x = 0; x < listaOpciones.getLength(); x++) {

                    //Creamos el nodo opcion
                    Node nodoOpcion = listaOpciones.item(x);
                    //Creamos el elemento opciones
                    Element elementoOpciones = (Element) nodoOpcion;

                    //Creamos el nodo OpcionUsuario
                    Node nodoOpcionUsuario = elementoOpciones.getAttributeNode("OpcionUsuario");
                    String valOpcionUsuario = (nodoOpcionUsuario != null) ? nodoOpcionUsuario.getTextContent() : null;


                    //Creamos el nodo texto
                    Node nodoTexto2 = elementoOpciones.getAttributeNode("texto");
                    String valTexto2 = (nodoTexto2 != null) ? nodoTexto2.getTextContent() : null;
                    //System.out.println("Opción: " + valOpcionUsuario + ": " + valTexto2);


                    //Creamos el nodo resultado
                    Node nodoResultado = elementoOpciones.getAttributeNode("resultado");
                    String valResultado = (nodoResultado != null) ? nodoResultado.getTextContent() : null;
                    // System.out.println("Resultado: " + valResultado);

                    //Creamos objeto opción
                    Opcion opcion = new Opcion();

                    opcion.setOpcionUsuario(Integer.parseInt(valOpcionUsuario));
                    opcion.setTexto(valTexto2);
                    opcion.setResultado(Integer.parseInt(valResultado));

                    opciones.add(opcion);


                }
                //Objeto de escena
                Escena escena = new Escena(Integer.parseInt(valCodigo), valTexto, opciones);

                escenas.add(escena);
            }

            //Objeto aventura
            Aventura aventura = new Aventura(valTitulo, escenas);

            //Llamamos al método
             juego(aventura);


        }catch(Exception e){
            e.printStackTrace();
        }



    }

    //Método para el juego al que se le pasa el objeto aventura dónde está toda la información del XML
    private static void juego (Aventura aventura){

        Scanner teclado = new Scanner(System.in);

        int escena = 1;
        int opcionElegida = 0;

        System.out.println();
        //Mientras no finalice la partide
        while(!finpartida){

            //Llamamos al método que muestra las escenas
            mostrarEscena (escena, aventura);
            //El usuario escribe la opción elegida por teclado
            if (!finpartida) {
                opcionElegida = teclado.nextInt();
                escena = comprobarResultado(opcionElegida, aventura, escena);
            }
        }

    }



    //Método que muestra la escena
    private static void mostrarEscena (int escena, Aventura aventura){

        for (int i = 0; i< aventura.getEscenas().size(); i++){

            Escena escena_i = aventura.getEscenas().get(i);

            if (escena_i.getCodigo() == escena){
                System.out.println(escena_i.getTexto());

                if (escena_i.getOpciones().isEmpty()){
                    finpartida = true;
                }
                for (int y = 0; y < escena_i.getOpciones().size(); y++){

                    Opcion opcion_y = escena_i.getOpciones().get(y);
                    System.out.println(opcion_y.getOpcionUsuario()+"-" + opcion_y.getTexto());
                }
            }

        }
    }

    private static int comprobarResultado(int opcionElegida, Aventura aventura, int escena) {

        for (int i = 0; i< aventura.getEscenas().size(); i++) {

            Escena escena_i = aventura.getEscenas().get(i);

            if (escena_i.getCodigo() == escena) {


                for (int y = 0; y < escena_i.getOpciones().size(); y++) {

                    Opcion opcion_y = escena_i.getOpciones().get(y);

                    if (opcionElegida == opcion_y.getOpcionUsuario()) {
                        return opcion_y.getResultado();
                    }

                }
            }

        }return 0;
    }








}




