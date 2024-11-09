$.validator.addMethod('filesize', function (value, elment, param) {
    return this.optional(elment) || elment.files[0].size <= param;
});