package org.example;
import java.io.IOException;
import java.io.FileWriter;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import java.util.HashMap;
import java.util.Map;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Gestor {

    private Map<Integer, Task> tasks;
    private int id = 1;
    private String idArchivo = LocalDateTime.now().format(DateTimeFormatter.ofPattern("yyyyMMdd_HHmmss"));

    public Gestor() {

        tasks = new HashMap<Integer, Task>();

    }

    public boolean addTask(Task newTask) {

        if (newTask == null) return false;

        tasks.put(id, newTask);
        id++;

        return true;
    }

    public boolean remTask(int id) {

        if (id == 0) return false;

        tasks.remove(id);

        return true;
    }

    public void Tasks() {

        if (tasks.isEmpty()) System.out.println("task-cli > No hay tareas para mostrar");

        else {

            for (var entry : tasks.entrySet()) {

                System.out.println("ID: " + entry.getKey() + " Task: " + entry.getValue());

            }
        }
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void verMenu() {

        System.out.println("task-cli > Hola, aquí tienes las instrucciones para usar el gestor: " +
                "\n- Añadir Task ==> add Descripcion" +
                "\n- Modificar Descripción Task ==> update TaskID Descripción" +
                "\n- Modificar Estado Task ==> update TaskID Status " +
                "\n- Eliminar Task ==> remove TaskID" +
                "\n- Ver Tasks ==> list o ==> list Status" +
                "\n- Buscar Task ==> searchf TaskID" +
                "\n- Exportar a JSON ==> export" +
                "\n- Limpiar Consola ==> clear" +
                "\n- Salir ==> exit" +
                "\ntask-cli > Para volver a ver este menú escribe 'task-menu'");

    }

    public String arrayToString(String[] array) {

        if (array.length == 0) return null;

        String myString = "";

        for (int i = 0; i < array.length; i++) {

            myString += array[i] + " ";

        }
        return myString;
    }

    public void filterList(State state) {

        Task myTask = new Task(0, null, state);

        if (tasks.isEmpty()) System.out.println("task-cli > No hay tareas para mostrar");

        else {

            for (var entry : tasks.entrySet()) {

                if (myTask.equals(tasks.get(entry.getKey()))) {

                    System.out.println(" Task: " + entry.getValue() + "'");

                }
            }
        }

    }

    public void getTaskByID(int id) {

        if (id <= 0) System.out.println("tasks-cli > ID no válido");

        else {

            if (tasks.get(id) == null) {
                System.out.println("tasks-cli > No existe esa tarea");
            }
            else {

                System.out.println("tasks-cli > Tarea: " + tasks.get(id).toString());

            }
        }
    }

    public boolean Contains(String[] array, String input) {

        for (int i = 0; i < array.length; i++) {

            if (array[i].toLowerCase().equals(input.toLowerCase()))
                return true;

        }

        return false;
    }

    public void cambiarEstado(String estado, int id) {

        State state = State.valueOf(estado);

        tasks.get(id).setState(state);

    }

    public void cambiarDescripcion(String newDesc, int id) {

        tasks.get(id).setDescription(newDesc);

    }

    public String getDesc(String[] array) {

        String myString = "";

        for (int i = 2; i < array.length; i++) {

            myString += array[i] + " ";

        }

        return myString;
    }

    public void mostrarPorEstado(State state, Task miTask) {

        for (int key: tasks.keySet()) {

            if (miTask.checkState(tasks.get(key))) {

                System.out.println("tasks-cli >  " + tasks.get(key).toString());

            }

        }


    }

    public void limpiarConsola() {
        for (int i = 0; i < 50; ++i) System.out.println();
    }

    public void exportar() {


        Gson gson = new GsonBuilder().setPrettyPrinting().create();
        String json = gson.toJson(tasks);
        System.out.println(tasks);
        String ruta = "C:\\Users\\Usuario\\Documents\\JSON\\datos" + idArchivo + ".json";

        try (FileWriter writer = new FileWriter(ruta)) {
            gson.toJson(tasks, writer);
            System.out.println("Archivo 'datos.json' guardado con éxito.");
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

}
