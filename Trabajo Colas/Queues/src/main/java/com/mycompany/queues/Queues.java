package com.mycompany.queues;
import java.util.LinkedList;
import java.util.Scanner;

public class Queues<T> {
    private LinkedList<T> q;

    public Queues() {
        q = new LinkedList<>();
    }

    public void Enqueue(T item) {
        q.add(item);
        System.out.println("Añadido a la cola: " + item);
    }

    public T Dequeue() {
        if (IsEmpty()) {
            System.out.println("La cola está vacía.");
            return null;
        }
        T item = q.removeFirst();
        System.out.println("Eliminado de la cola: " + item);
        return item;
    }

    public T Peek() {
        if (IsEmpty()) {
            System.out.println("La cola está vacía.");
            return null;
        }
        return q.getFirst();
    }

    public int Count() {
        return q.size();
    }

    public void Clear() {
        q.clear();
        System.out.println("La cola ha sido vaciada.");
    }

    public T GetFirst() {
        if (IsEmpty()) {
            System.out.println("La cola está vacía.");
            return null;
        }
        return q.getFirst();
    }

    public T GetLast() {
        if (IsEmpty()) {
            System.out.println("La cola está vacía.");
            return null;
        }
        return q.getLast();
    }

    public void GetAll() {
        if (IsEmpty()) {
            System.out.println("La cola está vacía.");
            return;
        }
        System.out.println("Elementos en la cola: " + q);
    }

    public boolean IsEmpty() {
        return q.isEmpty();
    }

    public static void main(String[] args) {
        Queues<Object> userQueue = new Queues<>();
        Scanner scanner = new Scanner(System.in);
        String input;

        while (true) {
            System.out.println("\nSeleccione una opción:");
            System.out.println("1. Añadir a la cola");
            System.out.println("2. Eliminar de la cola");
            System.out.println("3. Ver primer elemento");
            System.out.println("4. Contar elementos");
            System.out.println("5. Limpiar cola");
            System.out.println("6. Obtener primer elemento");
            System.out.println("7. Obtener último elemento");
            System.out.println("8. Obtener todos los elementos");
            System.out.println("9. Salir");
            System.out.print("Opción: ");
            input = scanner.nextLine();

            switch (input) {
                case "1":
                    System.out.print("Ingrese un valor (String, Double, Integer ): ");
                    String value = scanner.nextLine();
                    try {
                        // Intentar convertir a Integer
                        userQueue.Enqueue(Integer.parseInt(value));
                    } catch (NumberFormatException e1) {
                        try {
                            // Intentar convertir a Double
                            userQueue.Enqueue(Double.parseDouble(value));
                        } catch (NumberFormatException e2) {
                            // Si no se puede convertir, es un String
                            userQueue.Enqueue(value);
                        }
                    }
                    break;
                case "2":
                    userQueue.Dequeue();
                    break;
                case "3":
                    System.out.println("El rimer elemento es: " + userQueue.Peek());
                    break;
                case "4":
                    System.out.println("La cantidad de elementos en la cola es " + userQueue.Count());
                    break;
                case "5":
                    userQueue.Clear();
                    break;
                case "6":
                    System.out.println("El primer elemento de la cola es: " + userQueue.GetFirst());
                    break;
                case "7":
                    System.out.println("El último elemento de la cola es: " + userQueue.GetLast());
                    break;
                case "8":
                    userQueue.GetAll();
                    break;
                case "9":
                    System.out.println("Saliendo...");
                    scanner.close();
                    return;
                default:
                    System.out.println("Opción no válida. Inténtelo de nuevo.");
            }
        }
    }
}