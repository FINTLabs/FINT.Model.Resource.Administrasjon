pipeline {
  agent {
    docker {
      label 'docker'
      image 'microsoft/dotnet'
    }
  }
  stages {
    stage('Build') {
      environment {
        BINTRAY = credentials('fint-bintray')
      }
      when {
        branch 'master'
      }
      steps {
        retry(3) {
          sh 'git clean -fdx'
          sh 'dotnet restore'
        }
        sh 'dotnet build -c Release'
        sh 'dotnet test FINT.Model.Resource.Administrasjon.Tests'
        sh 'dotnet pack -c Release'
        archiveArtifacts '**/*.nupkg'
        sh "dotnet nuget push FINT.Model.Resource.Administrasjon/bin/Release/FINT.Model.Resource.Administrasjon.*.nupkg -k ${BINTRAY} -s https://api.bintray.com/nuget/fint/nuget"
      }
    }
  }
}
