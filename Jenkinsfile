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
        sh 'pkill WebApp'
        sh 'dotnet run WebApp/WebApp.csproj'
      }
    }

  }
}