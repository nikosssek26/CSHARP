public class Kata{
    public static int Grow(int[] x){
        int product = 1;
        for (int i = 0; i < x.Length; i++) product *= x[i];
        return product;
    }
}
