<?php

/*Utilizo require para poder incluir en este script de controlador 
el EquipoModel.php que no está en este script*/

require_once __DIR__ . '/../model/EquipoModel.php';

//Defino la clase para el equipo
class EquipoController {

    /*Y declaro equipoModel para almacenar una instancia de la clase EquipoModel
     que se encuentra en otro script distinto*/

    private $equipoModel;




    //Creo el constructor de la clase creando una nueva instancia
    public function __construct() {

        $this->equipoModel = new EquipoModel();
    }



    public function agregarEquipo($nombre, $ciudad, $deporte, $fecha) {
        // Crear una instancia del modelo
        $equipoModel = new EquipoModel();
    
        // Llamar a la función de inserción en el modelo
        $resultado = $equipoModel->insertarEquipo($nombre, $ciudad, $deporte, $fecha);
    
        // Compruebo si se insertó o no
        if ($resultado) {
            echo "Equipo insertado correctamente.";
        } else {
            echo "Error al insertar el equipo.";
        }
    }
    



    //Funcion que muestra los equipos que hay en la bbdd
    public function mostrarEquipos() {

        /*Llamo al método obtenerEquipos que está en el modelo e incluyo 
        la vista con su ruta para poder mostrarlo*/

        $equipos = $this->equipoModel->obtenerEquipos();
        require_once __DIR__ . '/../view/EquipoView.php';
    }









}
?>
