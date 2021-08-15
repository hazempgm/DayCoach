pipeline {
    agent any
    stages {
        stage('Build') {
		steps {
		    sh 'echo "Building..."'
		    sh 'sudo dotnet build WebApp/WebApp.csproj'
		}
        }

        stage('Deploy') {
		steps {
		    sh 'echo "Deploying..."'
		    sh 'sudo pkill WebApp'
		    sh 'sudo dotnet run WebApp/WebApp.csproj'
		}
        }
    }
}
