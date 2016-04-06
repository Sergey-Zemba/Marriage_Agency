function validateFilesUpload() {
            var fuData = $("#photoAlbum");
            var k = 0;
            var j = 0;
            for (var i = 0; i < fuData.get(0).files.length; i++) {
                var fileUploadPath = fuData.get(0).files[i].name;
                var extension = fileUploadPath.substring(fileUploadPath.lastIndexOf('.') + 1).toLowerCase();
                if (extension == "jpg" || extension == "jpeg") {
                    var size = fuData.get(0).files[i].size / 1024 / 1024;
                    if (size > 5) {
                        k++;
                    }
                } else {
                    j++;
                }
            }
            if (k > 0) {
                alert("Не все файлы будут загружены, т.к некоторые имеют размер больше 5МБ");
            }
            if (j > 0) {
                alert("Не все файлы будут загружены, т.к некоторые не имеют формат JPG или JPEG");
            }
        }