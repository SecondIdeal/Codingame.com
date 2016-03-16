numberOfElements = parseInt(readline()); // Number of elements which make up the association table.
numberOfFileNames = parseInt(readline()); // Number Q of file names to be analyzed.

typeDictionary = {};

for (i = 0; i < numberOfElements; i++) {
    inputs = readline().split(' ');
    typeDictionary[(inputs[0].toLowerCase())] = inputs[1];
}

for (i = 0; i < numberOfFileNames; i++) {
    fileName = readline(); // One file name per line.
    extension = "";

    if (fileName.indexOf(".") != -1) // Checking for a dot
        extension = fileName.substring(fileName.lastIndexOf(".") + 1).toLowerCase(); // Including a dot

    print(typeDictionary.hasOwnProperty(extension) ? typeDictionary[extension] : "UNKNOWN");
}