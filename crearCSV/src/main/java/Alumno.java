import java.util.Objects;

public class Alumno {

    private String nombre;
    private double nota1, nota2, nota3, media;
    private int ID;

    public Alumno() {
    }

    public Alumno(int ID, String nombre, double nota1, double nota2, double nota3) {
        this.ID = ID;
        this.nombre = nombre;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getNota1() {
        return nota1;
    }

    public void setNota1(double nota1) {
        this.nota1 = nota1;
    }

    public double getNota2() {
        return nota2;
    }

    public void setNota2(double nota2) {
        this.nota2 = nota2;
    }

    public double getNota3() {
        return nota3;
    }

    public void setNota3(double nota3) {
        this.nota3 = nota3;
    }

    public int getID() {
        return ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public double getMedia() {

        return (double) Math.round((nota1 + nota2 + nota3) / 3);

    }

    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;
        Alumno alumno = (Alumno) o;
        return getID() == alumno.getID();
    }

    @Override
    public int hashCode() {
        return Objects.hashCode(getID());
    }

    @Override
    public String toString() {
        return "Alumno {" +
                "  nombre = '" + nombre + "',\n" +
                "  nota1 = " + nota1 + ",\n" +
                "  nota2 = " + nota2 + ",\n" +
                "  nota3 = " + nota3 + ",\n" +
                "  ID = " + ID + "" + ",\n" +
                "  Media = " + getMedia() + "" +
                '}';
    }
}
