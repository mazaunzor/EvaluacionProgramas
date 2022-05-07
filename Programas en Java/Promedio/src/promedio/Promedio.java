/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package promedio;

import javax.swing.JOptionPane;

/**
 *
 * @author Edwin A. Mazariegos
 */
public class Promedio {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int numeros;    //declaramos la variable numeros la cual almacenara los datos ingresados por el usuario
        int limite = 3;   //declaramos la variable limite el cual sera la veces que vamos a requerir un numero para sacar el promedio
        int promedio;  //declaramos la varible promedio la que tendra el dato final

        for (int i = 1; i <= limite; i++) {  //creamos ciclo for para pedir 3 numeros
            numeros = Integer.parseInt(JOptionPane.showInputDialog("Ingrese un numero")); //pedimos el numero y lo almacenamos 

            int suma = numeros + numeros;   //vamos haciendo la suma de los numeros 

            if (i == limite) {  // verificamos que se hayan ingresados todos los numeros
                promedio = suma / limite; //procedemos hacer la operacion del promedio

                JOptionPane.showMessageDialog(null, "El promedio es: " + promedio);  //imprimimos el resultado
            }

        }

    }

}
