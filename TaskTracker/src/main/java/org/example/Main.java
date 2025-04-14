package org.example;

import java.util.InputMismatchException;
import java.util.Scanner;
//import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.File;
import java.io.IOException;

public class Main {

    public static void mostrarArray (String[] x) {

        for (int i = 0; i < x.length; i++) {
            System.out.print(x[i] + " ");
        }

    }

    public static void main(String[] args) {

        Gestor gestor = new Gestor();
        Scanner sc = new Scanner(System.in);

        String[] estados = {"NOT_DONE", "DONE", "IN_PROGRESS"};
        String input = null, description = null, str = "";
        String[] myInput = {"", "", ""};
        State state = State.NOT_DONE;
        int id = 1;

        gestor.verMenu();
        System.out.println("NOTA: Las tareas por defecto vienen como 'NOT_DONE', para cambiarlo usa 'update'.");


        while (true) {

            System.out.print("user-input > ");

            input = sc.nextLine();
            myInput = input.split(" ");

            if (myInput[0].equals("add")) {

                myInput[0] = "";

                description = gestor.arrayToString(myInput);

                System.out.println(description);

                gestor.addTask(new Task(id, description, state));

                System.out.println("task-cli > La tarea se ha añadido existosamente con ID " + id);
                id++;



            }
            else if (myInput[0].equals("update")) {

                try { str = myInput[2].trim().toUpperCase(); }
                catch (ArrayIndexOutOfBoundsException ex) {
                    System.out.println("task-cli > Añade una descripción o estado a al update porfavor");
                    continue;
                }

                id = Integer.parseInt(myInput[1]);

                if (gestor.Contains(estados, str)) {
                    gestor.cambiarEstado(str, id);
                }
                else {

                    str = gestor.getDesc(myInput);

                    gestor.cambiarDescripcion(str.toLowerCase(), id);
                }

                System.out.println("task-cli > Tarea actualizada correctamente");

            }
            else if (myInput[0].equals("remove")) {

                int myID = Integer.parseInt(myInput[1]);

                try {

                    gestor.remTask(myID);

                }
                catch (Exception e) {

                    System.out.println("tasks-cli > 'Mete un número adecuado'");
                    continue;

                }

                gestor.remTask(myID);

                System.out.println("task-cli > 'Tarea eliminada correctamente'");

            }
            else if (myInput[0].equals("list")) {

                try {
                    str = myInput[1];
                }
                catch (ArrayIndexOutOfBoundsException ex) {
                    gestor.Tasks();
                    continue;
                }

                if (gestor.Contains(estados, str.toUpperCase())) {

                    String estado = str;

                    State newState;

                    try {
                        newState = State.valueOf(estado);
                        System.out.println("tasks-cli > Filtrando tareas con el estado " + newState);
                    } catch (IllegalArgumentException e) {

                        continue;
                    }

                    Task newTask = new Task(0, null, State.valueOf(myInput[1].toUpperCase()));

                    gestor.mostrarPorEstado(newState, newTask);

                }
                else {System.out.println("tasks-cli > Estado no válido");}

            }
            else if (myInput[0].equals("searchf")) {

                gestor.getTaskByID(Integer.parseInt(myInput[1]));
                
            }
            else if (input.equals("task-menu")) { gestor.verMenu(); }
            else if (input.equals("exit")) {
                System.out.println("task-cli > Saliendo..."); return;
            }
            else if (input.equals("clear")) {
                gestor.limpiarConsola();
            }
            else if (input.equals("export")) {

                gestor.exportar();

            }

        }



    }
}