/*
GSON es una librería que pasándole una lista la formatea y exporta como JSON
*/

public class tutorialGSON {

        //Creamos el constructor     //Este método formatea el JSON para que salga con un formato bonito
        Gson gson = new GsonBuilder().setPrettyPrinting().create();

        //Creamos la String donde guardaremos el JSON de la lista
        String json = gson.toJson(tasks);

        //Ruta donde queremos exportar el JSON
        String ruta = "C:\\Users\\Usuario\\Documents\\JSON\\datos.json";

        //Con el filewriter exportamos el JSON
        try (FileWriter writer = new FileWriter(ruta)) {
            gson.toJson(tasks, writer); //Pasamos la lista con el writer a JSON
            System.out.println("Archivo 'datos.json' guardado con éxito.");
        } catch (IOException e) {
            e.printStackTrace();
        }

}
