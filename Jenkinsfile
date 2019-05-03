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
        timeout(10) {
            waitUntil {
                script {
                    sh 'git clean -fdx'
                    def r = sh returnStatus: true, script: 'dotnet restore -s https://api.bintray.com/nuget/fint/nuget'
                    return r == 0
                }
            }
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
