pipeline {
  agent any
  stages {
    stage('Prepare') {
      steps {
        dotnetToolRestore(noCache: true)
        dotnetRestore(noCache: true)
      }
    }

    stage('Build') {
      steps {
        dotnetBuild(configuration: 'Release', nologo: true, noRestore: true, unstableIfWarnings: true)
      }
    }

    stage('Test') {
      steps {
        dotnetTest(blame: true, noBuild: true, noRestore: true, nologo: true, unstableIfWarnings: true, logger: 'trx;LogFileName=unit_tests.xml')
        mstest(testResultsFile: '**/unit_tests.xml', failOnError: true, keepLongStdio: true)
      }
    }

    stage('Package') {
      steps {
        dotnetPublish(configuration: 'Release', noBuild: true, noDependencies: true, noRestore: true, nologo: true, unstableIfWarnings: true)
      }
    }

  }
}