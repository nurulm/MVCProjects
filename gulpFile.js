var gulp = require('gulp');
var concat = require('gulp-concat');
var iife = require('gulp-iife');
var rename = require('gulp-rename');
var uglify = require('gulp-uglify');
var minifyimage = require('gulp-imagemin');

//contactinating all js files - bundling
gulp.task('BundleJavaScript',function(){

     //return gulp.src(["./bower_components/angular/angular.js", "./bower_components/jquery/dist/jquery.js", "./bower_components/underscore/underscore.js","./bower_components/bootstrap/dist/js/bootstrap.js","./bower_components/jquery-ui/jquery-ui.js/"])
     return gulp.src(["./bower_components/jquery/dist/jquery.js","./bower_components/bootstrap/dist/js/bootstrap.js",
               "./bower_components/angular/angular.js","./bower_components/jquery-ui/jquery-ui.js/","./bower_components/underscore/underscore-min.js"])
     .pipe(concat('all.js'))
     .pipe(iife())
     .pipe(uglify())
     .pipe(gulp.dest('build'));

});