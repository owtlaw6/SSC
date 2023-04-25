/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplications7_4dva;
import java.security.InvalidAlgorithmParameterException;
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
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;
import javax.rmi.CORBA.Util;
/**
 *
 * @author student
 */
public class JavaApplicationS7_4dva {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException, IllegalBlockSizeException, BadPaddingException {
        // TODO code application logic here
        // get a Cipher instance for RSA with PKCS1 padding
        byte[] keyBytes = new byte[16];
        keyBytes = "ana are mere 111".getBytes();
        // declare secure PRNG
        SecureRandom myPRNG = new SecureRandom();
        // seed the key
        myPRNG.nextBytes(keyBytes);
        // build the key from random key bytes
        SecretKeySpec myKey = new SecretKeySpec(keyBytes, "RSA");
        // get a Cipher instance for RSA with PKCS1 padding
        Cipher myRSA = Cipher.getInstance("RSA/ECB/PKCS1Padding");
        // get an instance for the Key Generator
        KeyPairGenerator myRSAKeyGen = KeyPairGenerator.getInstance("RSA");
        // generate an 1024 bit key
        myRSAKeyGen.initialize(1024, myPRNG);
        KeyPair myRSAKeyPair= myRSAKeyGen.generateKeyPair();
        // store the public and private key individually
        Key pbKey = myRSAKeyPair.getPublic();
        Key pvKey = myRSAKeyPair.getPrivate();
        // init cipher for encryption
        myRSA.init(Cipher.ENCRYPT_MODE, pbKey, myPRNG);
        // encrypt, as expected we encrypt a symmetric key with RSA rather than a file or some longer stream which should be encrypted with AES
        byte[] ciphertext = myRSA.doFinal(keyBytes);
        // init cipher for decryption 
        myRSA.init(Cipher.DECRYPT_MODE, pvKey);
        // decrypt
        byte[] plaintext = myRSA.doFinal(ciphertext);
        System.out.println("plaintext: " + 
        javax.xml.bind.DatatypeConverter.printHexBinary(plaintext));
        System.out.println("ciphertext: " + 
        javax.xml.bind.DatatypeConverter.printHexBinary(ciphertext));
        System.out.println("keybytes: " + 
        javax.xml.bind.DatatypeConverter.printHexBinary(keyBytes));
    }
    
}
