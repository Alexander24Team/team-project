import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        System.out.print("Введите выражение: ");
        String expr = in.nextLine();

        String regex = "(dc((cddcd)|(ccddc))*)";
        Pattern ptrn = Pattern.compile(regex);
        Matcher checkExpr = ptrn.matcher(expr);

    }
}