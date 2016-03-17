numberOfElements = parseInt(readline()); // Number of elements which make up the association table.
numberOfFileNames = parseInt(readline()); // Number Q of file names to be analyzed.

file_extensions_association_array = {};

for (i = 0; i < numberOfElements; i++) {
    inputs = readline().split(' ');
    file_extensions_association_array[(inputs[0].toLowerCase())] = inputs[1];
}

for (i = 0; i < numberOfFileNames; i++) {
    fileName = readline(); // One file name per line.
    extension = "";

    if (fileName.indexOf(".") != -1) // Checking for a dot
        extension = fileName.substring(fileName.lastIndexOf(".") + 1).toLowerCase(); // Including a dot

    print(file_extensions_association_array.hasOwnProperty(extension) ? file_extensions_association_array[extension] : "UNKNOWN");
}