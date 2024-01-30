public class Main {
    public static void main(String[] args) {
        dirigirClientes();

    }

    public static void dirigirClientes() {
        // Declaración de la variable booleana carroGrande y asignación del valor true
        boolean carroGrande;
        carroGrande = true;

        // Generación de un número aleatorio entre 0 y 99 y almacenamiento en la
        // variable objetos
        int objetos = (int) (Math.random() * 100);

        // Si objetos es un número par, carroGrande se establece en true, de lo
        // contrario, se establece en false
        if ((objetos % 2) == 0) {
            carroGrande = true;
        } else {
            carroGrande = false;
        }

        // Evaluación del valor de objetos en una serie de declaraciones condicionales
        if (objetos < 10) {
            System.out.println("Por favor, diríjase a las cajas de autopago.");
            if (objetos < 3) {
                System.out.println("Por favor, diríjase a las cajas 1 y 2.");
            }
        } else {
            if (carroGrande) {
                System.out.println("Por favor, diríjase a las cajas 12 y 14.");
            } else {
                System.out.println("Por favor, diríjase a las cajas 10 y 11.");
            }
        }
    }
}
