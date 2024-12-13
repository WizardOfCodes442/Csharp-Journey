public class InsertionSort{
    public static void main(String[] args){
        for (int j =2 ; j < args.length; i++ ) {
            int key = parseInt(args[j]);
            int i = j-1;
            while (i > 0 && parseInt(args[i] > key)) {
                args[ i+1] = parseInt(args[i]);
                i = i - 1;

            }
            args[i + 1] = key;

        }
        for (int x=0; x < args.length; x++){
            System.out.print(args[x] + ", ");
        }
    }
} 