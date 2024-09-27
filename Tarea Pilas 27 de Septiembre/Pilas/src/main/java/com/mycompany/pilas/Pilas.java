package com.mycompany.pilas;
import java.util.Stack;
import java.util.Scanner;

public class Pilas {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Stack<Integer> pila = new Stack<Integer>();
        int res=0;
        int temp=0;
        do{
            System.out.println("Elija una opcion");
            System.out.println("1.- Agregar numero");
            System.out.println("2.- Eliminar numero anterior");
            System.out.println("3.- Mostrar pila");
            System.out.println("4.- Mostrar ultimo numero agregado");
            System.out.println("5.- Salir del programa");
            res=scan.nextInt();
            System.out.println("");
            switch(res){
                case 1:
                    System.out.println("Ingrese un numero entero");
                    pila.push(scan.nextInt());
                    System.out.println("");
                    break;
                case 2:
                    temp = pila.peek();
                    pila.pop();
                    System.out.println("Se elimino el ultimo numero: "+temp);
                    System.out.println("");
                    break;
                case 3: 
                    System.out.println("La pila actual es: "+pila);
                    System.out.println("");
                    break;
                case 4:
                    System.out.println("El ultimo numero en la pila es: "+pila.peek());
                    System.out.println("");
                    break;
                case 5:
                    System.out.println("Saliendo del programa");
                    break;
                default:
                    System.out.println("Ingrese una opcion correcta");
                    System.out.println("");
                    break;
                    
            }
        }
        while (res!=5);
        
        
    }
}
