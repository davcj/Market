var gulp = require('gulp');

gulp.task('default', function () {

});

var paths = {};
paths.webroot = "wwwroot/";
paths.npmSrc = "./node_modules";
paths.npmLibs = paths.webroot + "lib/npmlibs/";
paths.angularSource = "App/";

gulp.task('copy-angular', function () {
    return gulp.src(['!' + paths.angularSource + '*.ts', paths.angularSource + '**/*.js', paths.angularSource + '**/*.html', paths.angularSource + '**/*.css'])
                .pipe(gulp.dest(paths.webroot + '/app'));
})

