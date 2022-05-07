/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package leernumerostxt;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

/**
 *
 * @author Edwin A. Mazariegos
 */
public class LeerNumerostxt {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      
        int numeroEntero;
        


        File f = new File("c:/ficheros/evaluacion.txt");

        try  (Scanner entrada = new Scanner(f)) {

            //Primero están todos los int seguidos
            System.out.println("Números de tipo int: ");

            while (entrada.hasNextInt()) { //mientras queden enteros por leer
                numeroEntero = entrada.nextInt(); //se lee un entero del archivo
                System.out.print(numeroEntero + " "); //se muestra por pantalla
                
            }


        } catch (FileNotFoundException e) {
            System.out.println(e.toString());
        } catch (Exception e) {
            System.out.println(e.toString());
        }
    }
    }