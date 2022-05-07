/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package sumadenumeros;

import javax.swing.JOptionPane;

/**
 *
 * @author Edwin A. Mazariegos
 */
public class SumaDeNumeros {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        // TODO code application logic here
       
        int limite = 10;   //declaramos la variable limite el cual sera la veces que vamos a requerir un numero 
        int suma = 0;  //declaramos la varible SUMA

        for (int i = 1; i <= limite; i++) {//creamos ciclo for que se repetira 10 veces

            suma = suma + i; //SUMAMOS LOS NUMEROS

            JOptionPane.showMessageDialog(null, "La suma de los numeros del 1 al 10 \n " + "La suma es: " + suma);

        }
    }

}
