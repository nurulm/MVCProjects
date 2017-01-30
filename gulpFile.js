var gulp = require('gulp');
var concat = require('gulp-concat');
var iife = require('gulp-iife');
var rename = require('gulp-rename');
var uglify = require('gulp-uglify');
var minifyimage = require('gulp-imagemin');

//contactinating all js files - bundling
gulp.task('BundleJavaScript',function(){

     return gulp.src(["./bower_components/angular/angular.js", "./jquery/dist/jquery.js", "./underscore/underscore.js","./bootstrap/dist/js/bootstrap.js" ])
     .pipe(concat('all.js'))
     .pipe(iife())
     .pipe(uglify())
     .pipe(gulp.dest('build'));

});