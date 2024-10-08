package com.mycompany.balanceo_de_parentesis;
import java.util.Stack;

public class Balanceo_de_Parentesis {

    public static void main(String[] args) {
        String s = "[[{()}]]"; //Aqui se ponen los parentesis, corchetes o llaves que se deseen
        boolean res=validacion(s);
        System.out.println("Esta balanceado?: "+res);
    }
    public static boolean validacion (String s){
        Stack<Character> pila = new Stack<Character>();
        for (int i=0;i<s.length();i++){
            char caracter=s.charAt(i);
            if (caracter=='('||caracter=='['||caracter=='{'){
                pila.push(caracter);
            }
            else {
                if (pila.isEmpty()){
                    return false;
                }
                char caracterfin = pila.pop();
                if ((caracterfin=='('&& caracter==')')||(caracterfin=='['&&caracter==']')||(caracterfin=='{'&&caracter=='}')){
                    continue;
                }
                else{
                    return false;
                }
                    
            }
        }
        return pila.isEmpty();
    }
    
}
