import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);

        int numberOfElements = in.nextInt(); // Number of elements which make up the association table.
        in.nextLine();
        int numberOfFileNames = in.nextInt(); // Number Q of file names to be analyzed.
        in.nextLine();

        HashMap<String, String> typeDictionary = new HashMap<String, String>();

        for (int i = 0; i < numberOfElements; i++) {
            String extension = in.next(); // file extension
            String mimeType = in.next(); // MIME type.
            in.nextLine();

            typeDictionary.put(extension.toLowerCase(), mimeType);
        }

        for (int i = 0; i < numberOfFileNames; i++) {
            String fileName = in.nextLine(); // One file name per line.
            String extension = "";

            if (fileName.indexOf(".") != -1) // Checking for a dot
                extension = fileName.substring(fileName.lastIndexOf(".") + 1).toLowerCase(); // Including a dot

            System.out.println(typeDictionary.containsKey(extension) ? typeDictionary.get(extension) : "UNKNOWN");
        }
    }
}