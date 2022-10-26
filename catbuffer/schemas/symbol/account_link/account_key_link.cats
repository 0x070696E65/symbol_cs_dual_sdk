import "transaction.cats"

# Shared content between AccountKeyLinkTransactionBody and EmbeddedAccountKeyLinkTransaction.
inline struct AccountKeyLinkTransactionBody
	# Linked public key.
	linked_public_key = PublicKey

	# Account link action.
	link_action = LinkAction

# This transaction is required for all accounts wanting to activate remote or delegated harvesting (V1, latest).
#
# Announce an AccountKeyLinkTransaction to delegate the account importance score to a proxy account.
struct AccountKeyLinkTransactionV1
	TRANSACTION_VERSION = make_const(uint8, 1)
	TRANSACTION_TYPE = make_const(TransactionType, ACCOUNT_KEY_LINK)

	inline Transaction
	inline AccountKeyLinkTransactionBody

# Embedded version of AccountKeyLinkTransaction (V1, latest).
struct EmbeddedAccountKeyLinkTransactionV1
	TRANSACTION_VERSION = make_const(uint8, 1)
	TRANSACTION_TYPE = make_const(TransactionType, ACCOUNT_KEY_LINK)

	inline EmbeddedTransaction
	inline AccountKeyLinkTransactionBody
