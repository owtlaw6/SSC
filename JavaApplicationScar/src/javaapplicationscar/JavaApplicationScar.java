/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package javaapplicationscar;

import static com.sun.javafx.fxml.expression.Expression.multiply;
import static com.sun.javafx.fxml.expression.Expression.multiply;
import java.math.BigInteger;
import static javafx.beans.binding.Bindings.multiply;

/**
 *
 * @author student
 */
public class JavaApplicationScar {
    
    private static BigInteger NaiveSquareRootSearch(BigInteger a, BigInteger left, BigInteger right){
        // fix root as the arithmetic mean of left and right
       BigInteger root = left.add(right).shiftRight(1);
        // if the root is not between [root, root+1], 
        //is not an integer and root is our best integer approximation
       if(!((root.pow(2).compareTo(a) == - 1)&&(root.add(BigInteger.ONE).pow(2).compareTo(a) == 1))){
           if (root.pow(2).compareTo(a) == -1) root = NaiveSquareRootSearch(a, root, right);
           if (root.pow(2).compareTo(a) == 1) root = NaiveSquareRootSearch(a, left, root);
       }
       return root;
    }
    public static BigInteger SquareRoot(BigInteger a) {
        return NaiveSquareRootSearch(a, BigInteger.ZERO, a);
    }
    
    private static BigInteger NaiveCubicRootSearch(BigInteger a, BigInteger left, BigInteger right){
        // fix root as the arithmetic mean of left and right
       BigInteger root = left.add(right).shiftRight(1);
        // if the root is not between [root, root+1], 
        //is not an integer and root is our best integer approximation
       if(!((root.pow(3).compareTo(a) == - 1)&&(root.add(BigInteger.ONE).pow(3).compareTo(a) == 1))){
           if (root.pow(3).compareTo(a) == -1) root = NaiveCubicRootSearch(a, root, right);
           if (root.pow(3).compareTo(a) == 1) root = NaiveCubicRootSearch(a, left, root);
       }
       return root;
    }
    public static BigInteger CubicRoot(BigInteger a) {
        return NaiveCubicRootSearch(a, BigInteger.ZERO, a);
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
     BigInteger e = new BigInteger("7");
     BigInteger n = new BigInteger("837210799");
     BigInteger d = new BigInteger("478341751");
     BigInteger k = (d.multiply(e).subtract(new BigInteger("1")).divide(n)).add(new BigInteger ("1"));
     System.out.println("k = " + k);
     BigInteger pqsum = n.add(new BigInteger ("1")).subtract(d.multiply(e).subtract(new BigInteger("1")).divide(k));
     System.out.println("p + q = " + pqsum);
     BigInteger delta = pqsum.multiply(pqsum).subtract(new BigInteger("4").multiply(n));
     System.out.println("delta = " + delta);
     BigInteger x1 = pqsum.add(SquareRoot(delta)).divide(new BigInteger("2"));
     System.out.println("x1 = " + x1);
     BigInteger x2 = pqsum.subtract(SquareRoot(delta)).divide(new BigInteger("2"));
     System.out.println("x2 = " + x2 + "\n");
     
     BigInteger e1 = new BigInteger("3");
     BigInteger n1 = new BigInteger("8716664131891073309298060436222387808362956786786341866937428783455365962391673917249574491595229207084297741464557132198229086365652604590297378403184129");
     BigInteger c1 = new BigInteger("1375865583010982618632308529423371271821438577980922927124130396877925863587827122886875024570556859122064458153631");
     BigInteger m = CubicRoot(c1);
     System.out.println("m = " + m);
     if(m.pow(3).compareTo(c1) == 0)
         System.out.println("da\n");
     else System.out.println("nu\n");
    }
    
}
