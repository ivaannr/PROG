public interface Combatiente {

    /**
     * Este metodo le pasa el daño al juagdor atacado
     * @param objetivo Objetivo al que se le quiere atacar
     */
    void atacar(Combatiente objetivo);

    /**
     * Este metodo recibe daño
     *
     * @param damage Daño causado a nuestro jugador
     * @return
     */
    void recibirDamage(double damage);

    /**
     * Este metodo retorna el nombre
     * @return Nombre
     */
    String getNombre();

    /**
     * Este metodo retorna la salud
     * @return Salud
     */
    double getSalud();

    String getTipo();

}
