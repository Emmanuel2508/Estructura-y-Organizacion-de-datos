package com.mycompany.cadena_invertida;
import java.util.Scanner;

public class Cadena_Invertida {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("introduce una cadena");
        String cadena=scan.nextLine();
        String cadenainvertida=invertido(cadena);
        System.out.println("cadena introducida: "+cadena);
        System.out.println("Cadena invertida: "+cadenainvertida);
        
    }
    public static String invertido(String cadena){
        if (cadena.length()==1){
            return cadena;
        }
        else{
            return invertido(cadena.substring(1)) + cadena.charAt(0);
        }
            
    }
}
