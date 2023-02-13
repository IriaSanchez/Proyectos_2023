package org.example;

public class Opcion {

    private int OpcionUsuario;
    private String texto;
    private int resultado;

    public Opcion() {
    }

    public Opcion(int opcionUsuario, String texto, int resultado) {
        OpcionUsuario = opcionUsuario;
        this.texto = texto;
        this.resultado = resultado;
    }

    public int getOpcionUsuario() {
        return OpcionUsuario;
    }

    public void setOpcionUsuario(int opcionUsuario) {
        OpcionUsuario = opcionUsuario;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    public int getResultado() {
        return resultado;
    }

    public void setResultado(int resultado) {
        this.resultado = resultado;
    }

    @Override
    public String toString() {
        return "Opciones{" +
                "OpcionUsuario=" + OpcionUsuario +
                ", texto='" + texto + '\'' +
                ", resultado=" + resultado +
                '}';
    }
}
