void Main()
{
	string message;
	string key;
	string pubKey;
	pubKey = "bye";
	key = "hello";
	message = "testing123";
	System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
	byte[] keyByte = encoding.GetBytes(key);
	//HMACMD5 hmacmd5 = new HMACMD5(keyByte);
	HMACSHA256 hmacsha1 = new HMACSHA256(keyByte);
	byte[] messageBytes = encoding.GetBytes(message);
	byte[] hashmessage = hmacsha1.ComputeHash(messageBytes);
	var hash = ByteToString(hashmessage); 
	
	
	hash.Dump();
	
	var test = CheckHMAC("testing123", hash, key);
	test.Dump();
}

// Define other methods and classes here
public static string ByteToString(byte[] buff)
{
	string sbinary = "";
	for (int i = 0; i < buff.Length; i++)
	{
		sbinary += buff[i].ToString("X2"); // hex format
	}
	return (sbinary);


}

public static string CheckHMAC(string message, string oHash, string key)
{
	
	string pubKey;
	pubKey = "bye";
	key = "hello";
	System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
	byte[] keyByte = encoding.GetBytes(key);
	//HMACMD5 hmacmd5 = new HMACMD5(keyByte);
	HMACSHA256 hmacsha1 = new HMACSHA256(keyByte);
	byte[] messageBytes = encoding.GetBytes(message);
	byte[] hashmessage = hmacsha1.ComputeHash(messageBytes);
	var hash = ByteToString(hashmessage);
	
	return hash;
}
