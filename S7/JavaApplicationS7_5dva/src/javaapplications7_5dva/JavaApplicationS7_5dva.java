/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplications7_5dva;

import java.security.InvalidKeyException;
import java.security.Key;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;
import java.security.spec.InvalidKeySpecException;
import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;

/**
 *
 * @author student
 */
public class JavaApplicationS7_5dva {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException, IllegalBlockSizeException, BadPaddingException, InvalidKeySpecException {
        // TODO code application logic here

        byte[] keyBytes = new byte[16];
        // declare secure PRNG
        SecureRandom myPRNG = new SecureRandom();
        // seed the key
        myPRNG.nextBytes(keyBytes);
        // build the key from random key bytes
        SecretKeySpec myKey = new SecretKeySpec(keyBytes, "RSA");
        
        char[] password = "short_password".toCharArray();
        byte[] salt = new byte[16];
        int iteration_count = 10000;
        int key_size = 128;
        // set salt values to random 
        myPRNG.nextBytes(salt);

        // initialize key factory for HMAC-SHA1 derivation
        SecretKeyFactory keyFactory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1"); 
        // set key specification
        PBEKeySpec pbekSpec = new PBEKeySpec(password, salt, iteration_count, key_size);
        // generate the key
        SecretKey myRSAPBKey = new SecretKeySpec( keyFactory.generateSecret(pbekSpec).getEncoded(), "RSA");
        // print the key
        System.out.println("RSA key: " + javax.xml.bind.DatatypeConverter.printHexBinary(myRSAPBKey.getEncoded()));
        keyBytes = myRSAPBKey.getEncoded();
        
        // get a Cipher instance for RSA with PKCS1 padding
        
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
