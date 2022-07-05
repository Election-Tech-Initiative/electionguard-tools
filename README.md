![Microsoft Defending Democracy Program: ElectionGuard Tools][banner image]

# 🗳 ElectionGuard Tools

[![ElectionGuard Specification 0.95.0](https://img.shields.io/badge/🗳%20ElectionGuard%20Specification-0.95.0-green)](https://www.electionguard.vote) ![Github Package Action](https://github.com/microsoft/electionguard-python/workflows/Release%20Build/badge.svg) [![](https://img.shields.io/pypi/v/electionguard)](https://pypi.org/project/electionguard/) [![](https://img.shields.io/pypi/dm/electionguard)](https://pypi.org/project/electionguard/) [![Language grade: Python](https://img.shields.io/lgtm/grade/python/g/microsoft/electionguard-python.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/microsoft/electionguard-python/context:python) [![Total alerts](https://img.shields.io/lgtm/alerts/g/microsoft/electionguard-python.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/microsoft/electionguard-python/alerts/) [![Documentation Status](https://readthedocs.org/projects/electionguard-python/badge/?version=latest)](https://electionguard-python.readthedocs.io) [![license](https://img.shields.io/github/license/microsoft/electionguard)](https://github.com/microsoft/electionguard-python/blob/main/LICENSE)

This repository is a "reference implementation" of ElectionGuard written in Python 3. This implementation can be used to conduct End-to-End Verifiable Elections as well as privacy-enhanced risk-limiting audits. Components of this library can also be used to construct "Verifiers" to validate the results of an ElectionGuard election.

## 📁 In This Repository

| File/folder                                             | Description                                    |
| ------------------------------------------------------- | ---------------------------------------------- |
| [docs](/docs)                                           | Documentation for using the tools.             |
| [src/GenerateVerifierTests](/src/GenerateVerifierTests) | Verifier Test Generator.                       |
| [CONTRIBUTING.md](/CONTRIBUTING.md)                     | Guidelines for contributing.                   |
| [README.md](/README.md)                                 | This README file.                              |
| [LICENSE](/LICENSE)                                     | The license for ElectionGuard-Tools.          |

## ❓ What Is ElectionGuard?

ElectionGuard is an open source software development kit (SDK) that makes voting more secure, transparent and accessible. The ElectionGuard SDK leverages homomorphic encryption to ensure that votes recorded by electronic systems of any type remain encrypted, secure, and secret. Meanwhile, ElectionGuard also allows verifiable and accurate tallying of ballots by any 3rd party organization without compromising secrecy or security.

Learn More in the [ElectionGuard Repository](https://github.com/microsoft/electionguard)

## 🦸 How Can I use ElectionGuard?

ElectionGuard supports a variety of use cases. The Primary use case is to generate verifiable end-to-end (E2E) encrypted elections. The ElectionGuard process can also be used for other use cases such as privacy enhanced risk-limiting audits (RLAs).
# Project

> This repo has been populated by an initial template to help get you started. Please
> make sure to update the content to build a great experience for community-building.

As the maintainer of this project, please make a few updates:

- Improving this README.MD file to provide a great experience
- Updating SUPPORT.MD with content about this project's support experience
- Understanding the security reporting process in SECURITY.MD
- Remove this section from the README

## Contributing

This project encourages community contributions for development, testing, documentation, code review, and performance analysis, etc. For more information on how to contribute, see [the contribution guidelines][contributing]

### Code of Conduct

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

### Reporting Issues

Please report any bugs, feature requests, or enhancements using the [GitHub Issue Tracker](https://github.com/microsoft/electionguard-python/issues). Please do not report any security vulnerabilities using the Issue Tracker. Instead, please report them to the Microsoft Security Response Center (MSRC) at [https://msrc.microsoft.com/create-report](https://msrc.microsoft.com/create-report). See the [Security Documentation][security] for more information.

### Have Questions?

Electionguard would love for you to ask questions out in the open using GitHub Issues. If you really want to email the ElectionGuard team, reach out at electionguard@microsoft.com.
## License

This repository is licensed under the [MIT License]

## Thanks! 🎉

A huge thank you to those who helped to contribute to this project so far, including:

<!-- Links -->

[banner image]: https://raw.githubusercontent.com/microsoft/electionguard-python/main/images/electionguard-banner.svg
[pull request workflow]: https://github.com/microsoft/electionguard-python/blob/main/.github/workflows/pull_request.yml
[contributing]: https://github.com/microsoft/electionguard-python/blob/main/CONTRIBUTING.md
[security]: https://github.com/microsoft/electionguard-python/blob/main/SECURITY.md
[design and architecture]: https://github.com/microsoft/electionguard-python/blob/main/docs/Design_and_Architecture.md
[build and run]: https://github.com/microsoft/electionguard-python/blob/main/docs/Build_and_Run.md
[project workflow]: https://github.com/microsoft/electionguard-python/blob/main/docs/Project_Workflow.md
[election manifest]: https://github.com/microsoft/electionguard-python/blob/main/docs/Election_Manifest.md
[configure election]: https://github.com/microsoft/electionguard-python/blob/main/docs/0_Configure_Election.md
[key ceremony]: https://github.com/microsoft/electionguard-python/blob/main/docs/1_Key_Ceremony.md
[encrypt ballots]: https://github.com/microsoft/electionguard-python/blob/main/docs/2_Encrypt_Ballots.md
[cast and spoil]: https://github.com/microsoft/electionguard-python/blob/main/docs/3_Cast_and_Spoil.md
[decrypt tally]: https://github.com/microsoft/electionguard-python/blob/main/docs/4_Decrypt_Tally.md
[publish and verify]: https://github.com/microsoft/electionguard-python/blob/main/docs/5_Publish_and_Verify.md
[mit license]: https://github.com/microsoft/electionguard-python/blob/main/LICENSE