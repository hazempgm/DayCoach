pipeline {
    agent any
    stages {
        stage('Build') {
            sh 'echo "Building..."'
            sh 'dotnet build WebApp/WebApp.csproj'
        }

        stage('Deploy') {
            sh 'echo "Deploying..."'
	    sh 'pkill WebApp'
            sh 'dotnet run WebApp/WebApp.csproj'
        }
    }
}
