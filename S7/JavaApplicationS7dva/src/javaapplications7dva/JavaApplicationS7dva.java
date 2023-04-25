/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplications7dva;

import java.security.Key;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.Security;
import java.security.SecureRandom;
import javax.crypto.Cipher;
import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.crypto.BadPaddingException;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.ShortBufferException;
import javax.crypto.spec.SecretKeySpec;
import javax.rmi.CORBA.Util;
/**
 *
 * @author student
 */
public class JavaApplicationS7dva {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        byte[] keyBytes = new byte[16];
        // declare secure PRNG
        SecureRandom myPRNG = new SecureRandom();
        // seed the key
        myPRNG.nextBytes(keyBytes);
        // build the key from random key bytes
        SecretKeySpec myKey = new SecretKeySpec(keyBytes, "AES");
        // instantiate AES object for ECB with no padding
        Cipher myAES = null;
        try {
            myAES = Cipher.getInstance("AES/ECB/NoPadding");
        } catch (NoSuchAlgorithmException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        } catch (NoSuchPaddingException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            // initialize AES objecy to encrypt mode
            myAES.init(Cipher.ENCRYPT_MODE, myKey);
        } catch (InvalidKeyException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        }
        // initialize plaintext
        byte[] plaintext = new byte[16];
        plaintext = "ana are mere 111".getBytes();
        //initialize ciphertext
        byte[] ciphertext = new byte[16];
        // update cipher with the plaintext
        int cLength = 0;
        try {
            cLength = myAES.update(plaintext, 0, plaintext.length, ciphertext, 0);
        } catch (ShortBufferException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            // process remaining blocks of plaintext
            cLength += myAES.doFinal(ciphertext, cLength);
        } catch (IllegalBlockSizeException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ShortBufferException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        } catch (BadPaddingException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        }
        // print plaintext and ciphertext
        System.out.println("plaintext: " + javax.xml.bind.DatatypeConverter.printHexBinary(plaintext));
        System.out.println("ciphertext: " + javax.xml.bind.DatatypeConverter.printHexBinary(ciphertext));
        try {
            // initialize AES for decryption
            myAES.init(Cipher.DECRYPT_MODE, myKey);
        } catch (InvalidKeyException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        }
        // initialize a new array of bytes to place the decryption
        byte[] dec_plaintext = new byte[16];
        try {
            cLength = myAES.update(ciphertext, 0, ciphertext.length, dec_plaintext, 0);
        } catch (ShortBufferException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            // process remaining blocks of ciphertext
            cLength += myAES.doFinal(dec_plaintext, cLength);
        } catch (IllegalBlockSizeException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ShortBufferException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        } catch (BadPaddingException ex) {
            Logger.getLogger(JavaApplicationS7dva.class.getName()).log(Level.SEVERE, null, ex);
        }
        // print the new plaintext (hopefully identical to the initial one)
        System.out.println("decrypted: " + javax.xml.bind.DatatypeConverter.printHexBinary(dec_plaintext));

    }
    
}
