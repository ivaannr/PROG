package org.example;
import java.util.Objects;

public class Task implements Comparable<Task> {

    private int id = 0;
    private String description = null;
    private State state = State.NOT_DONE;

    public Task() {}

    public Task(int id, String description, State state) {
        this.id = id;
        this.description = description;
        this.state = state;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public State getState() {
        return state;
    }

    public void setState(State state) {
        this.state = state;
    }

    @Override
    public boolean equals(Object o) {
        if (!(o instanceof Task)) return false;
        Task task = (Task) o;
        return id == task.id && Objects.equals(description, task.description) && state == task.state;
    }

    public boolean checkState(Object o) {
        if (!(o instanceof Task)) return false;
        Task task = (Task) o;
        return state == task.state;
    }

    @Override
    public int hashCode() {
        return Objects.hash(id, description, state);
    }

    @Override
    public String toString() {
        return "Description:" + this.description + "|| State: " + this.state;
    }

    @Override
    public int compareTo(Task o) {
        return 0;
    }
}
