pipeline {
    agent any
    stages {
        stage('Build') {
		steps {
		    sh 'echo "Building..."'
		    sh 'dotnet build WebApp/WebApp.csproj'
		}
        }

        stage('Deploy') {
		steps {
		    sh 'echo "Deploying..."'
		    sh 'echo "Running..."'
		    sh 'pkill WebApp || echo > /dev/null'
		    sh 'dotnet WebApp/bin/Release/net5.0/WebApp.dll & disown %1'
		}
        }
    }
}
