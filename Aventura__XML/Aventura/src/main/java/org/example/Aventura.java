package org.example;

import java.util.ArrayList;

public class Aventura {

    private String titulo;
    private ArrayList<Escena> escenas;

    public Aventura() {
    }

    public Aventura(String titulo, ArrayList<Escena> escenas) {
        this.titulo = titulo;
        this.escenas = escenas;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public ArrayList<Escena> getEscenas() {
        return escenas;
    }

    public void setEscenas(ArrayList<Escena> escenas) {
        this.escenas = escenas;
    }

    @Override
    public String toString() {
        return "Aventura{" +
                "titulo='" + titulo + '\'' +
                ", escenas=" + escenas +
                '}';
    }
}